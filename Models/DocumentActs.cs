using MovieLecMvcWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieLecMvcWeb.Models
{
    public class DocumentActs
    {
        public List<Document> GetDocuments()
        {
            DocumentData data = new DocumentData();
            return data.Documents;
        }
    }
}