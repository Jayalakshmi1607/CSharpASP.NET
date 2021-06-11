using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace AttributeRouting.Controllers
{
    [RoutePrefix("api/travel")]
    public class TravelController:ApiController
    {
        TravelHistoryRepo travelHistoryRepo = new TravelHistoryRepo();
        TravelHistory travelHistoryObj = new TravelHistory();
        [HttpGet,Route("Get")]
        public IEnumerable<TravelHistory> GetTravelHistory()
        {
            return travelHistoryRepo.GetTravelHistory();
        }
        [HttpGet,Route("GetById/{id}")]
        public List<TravelHistory> GetTravelData(string id)
        {
            travelHistoryObj._cn6ca = id;
           return travelHistoryRepo.GetTraveller(travelHistoryObj);
        }
        [HttpPost,Route("AddTraveller")]
        public void AddTraveller([FromBody] TravelHistory travelHistory)
        {
            travelHistoryRepo.AddTraveller(travelHistory);
        }
        [HttpPut,Route("UpdateTraveller")]
        public void UpdateTraveller([FromBody] TravelHistory travelHistory)
        {
            travelHistoryRepo.UpdateTraveller(travelHistory);
        }
        [HttpDelete,Route("DeleteTraveller/{id}")]
        public void DeleteTraveller(string id)
        {
            travelHistoryObj._cn6ca = id;
            travelHistoryRepo.DeleteTraveller(travelHistoryObj);
        }
    }
}