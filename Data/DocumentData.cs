using MovieLecMvcWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieLecMvcWeb.Data
{
    public class DocumentData
    {
        public List<Document> Documents
        {
            get
            {
                return new List<Document>
                {
                    new Document{ Num=1, Title="타이틀1", Name="홍길동"},
                    new Document{ Num=2, Title="타이틀2", Name="사나"},
                    new Document{ Num=3, Title="타이틀3", Name="모모"},
                    new Document{ Num=4, Title="타이틀4", Name="두니"},
                    new Document{ Num=5, Title="타이틀5", Name="김철수"},
                    new Document{ Num=6, Title="타이틀6", Name="이영희"}
                };
            }
        }
    }
}