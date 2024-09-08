using DataAccessLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Responses
{
    public class LessonContentResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public LessonContentTypesEnum Type { get; set; }
        public string Link { get; set; }
        public string Content { get; set; }
    }
}
