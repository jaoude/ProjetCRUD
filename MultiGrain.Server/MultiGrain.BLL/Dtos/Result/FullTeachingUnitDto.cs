﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MultiGrain.BLL.Dtos.Result
{
    public class ListFullTeachingUnitDto
    {
       public List<FullTeachingUnitDto> list { get; set; }
        public ListFullTeachingUnitDto()
        {
            list = new List<FullTeachingUnitDto>();
            list.Add(new FullTeachingUnitDto("1","S1","T1","C1","M1","C1","cat1","in1","p1","2018"));
            list.Add(new FullTeachingUnitDto("2", "S1", "T2", "C2", "M2", "C2", "cat2", "in2", "p2","2018"));
            list.Add(new FullTeachingUnitDto("3", "S3", "T3", "C3", "M3", "C3", "cat3", "in3", "p3","2019"));
            list.Add(new FullTeachingUnitDto("3", "S3", "T4", "C4", "M4", "C4", "cat4", "in4", "p4","2019"));
            list.Add(new FullTeachingUnitDto("3", "S3", "T4", "C4", "M4", "C4", "cat4", "in4", "p4","2020"));
        }
    }
   public class FullTeachingUnitDto
    {
        public FullTeachingUnitDto(string id, string semestre, string title, string
            credits, string mode, string cygle, string catalog, string instituion, string program,string year)
        {
            this.id = id;
            this.semestre = semestre;
            this.title = title;
            this.credits = credits;
            this.mode = mode;
            this.cygle = cygle;
            this.catalog = catalog;
            this.instituion = instituion;
            this.program = program;
            this.year = year;
        }
        public string id { get; set; }
        public string semestre { get; set; }
        public string title { get; set; }
        public string credits { get; set; }
        public string mode { get; set; }
        public string cygle { get; set; }
        public string catalog { get; set; }

        public string instituion { get; set; }
        public string program { get; set; }

        public string year { get; set; }
        //    Id :number;
        //semestre: number;
        //title: string;
        //credits: string;
        //mode: string;
        //cygle: string;
        //catalognumb: string;
    }
}
