using WebApplication1.Domain.Entidades;
using WebApplication1.Domain.InterfaceRepository;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace WebApplication1.Domain.InterfaceRepository
{
    public class CompromissoRepository : ICompromissoRepository
    {
        private readonly IConfiguration _configuration;

       //private readonly string _connectionString = "Server=DESKTOP-3S4pmgo;Database=ProjetoCompromisso;Trusted_Connection=True;MultipleActiveResultSets=true";

        public CompromissoRepository(IConfiguration Configuration)
        {
            _configuration = Configuration;
        }

        public IEnumerable<Compromisso> GetAll()
        {
            using (IDbConnection dbConnection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                dbConnection.Open();
                var lsCompromisso = dbConnection.Query<Compromisso>("SELECT * FROM Compromissos");
                return lsCompromisso;
            }
        }

        public IEnumerable<Compromisso> GetByNatureza(string Natureza)
        {
            using (IDbConnection dbConnection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
               
                dbConnection.Open();
                var param = new DynamicParameters();
                param.Add("NT", Natureza);
                var lsCompromisso = dbConnection.Query<Compromisso>("SELECT * FROM Compromissos WHERE Natureza = @NT", param);
                return lsCompromisso;
            }
        }
    }
}