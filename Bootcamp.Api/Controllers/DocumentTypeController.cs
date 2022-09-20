using Bootcamp.Queries.DocumentType;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bootcamp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentTypeController : ControllerBase
    {
        private readonly IDocumentTypeQueries _documentTypeQueries;

        public DocumentTypeController(IDocumentTypeQueries documentTypeQueries)
        {
            _documentTypeQueries = documentTypeQueries;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult> GetAll()
        {
            var result = await _documentTypeQueries.GetAll();
            return Ok(result);
        }
    }
}
