using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SurveyOnline.Models;

namespace SurveyOnline.ViewModels
{
    public class AnswerFormViewModel
    {
        public Response Response { get; set; }
        public Survey Survey { get; set; }
    }
}