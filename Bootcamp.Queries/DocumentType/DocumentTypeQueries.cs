using Bootcamp.ViewModel;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.Queries.DocumentType
{
    public class DocumentTypeQueries : IDocumentTypeQueries
    {
        private readonly string _connectionString;

        public DocumentTypeQueries(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:SQL"];
        }

        public async Task<IEnumerable<DocumentTypeViewModel>> GetAll()
        {
            IEnumerable<DocumentTypeViewModel> result = new List<DocumentTypeViewModel>();

            using (var connection = new SqlConnection(_connectionString))
            {
                result = await connection.QueryAsync<DocumentTypeViewModel>("[dbo].[Usp_Sel_DocumentType]", commandType: System.Data.CommandType.StoredProcedure);
            }

            return result;
        }
    }
}
