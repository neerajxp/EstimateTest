using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EstimateCreator.Models;

namespace EstimateCreator.Models
{
    public class EstimateCreatorViewModel
    {
        public EstimateHeader EstimateHeader { get; set; }
        public EstimatePublication EstimatePublication { get; set; }
        public EstimateEdition EstimateEdition { get; set; }

    }
}