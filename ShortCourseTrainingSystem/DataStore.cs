using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortCourseTrainingSystem
{
    internal class DataStore
    {
        public static List<Dictionary<string, string>> courses = new List<Dictionary<string, string>>()
        {
            new Dictionary<string, string>()
            {
                {"id","1" },
                {"name","Microsoft Office" },
                {"period","4month" },
                {"price","38" },
                {"monthlyPrice", "10"},
                {"createAt","5/28/2023 10:19:34 PM" },
                {"updateAt","" }
            },
            new Dictionary<string, string>()
            {
                {"id","2" },
                {"name","Chinese Level 1A" },
                {"period","3month" },
                {"price","35" },
                {"monthlyPrice", "15"},
                {"createAt","5/19/2023 10:19:34 PM" },
                {"updateAt","" }
            },
            new Dictionary<string, string>()
            {
                {"id","3" },
                {"name","English Beginner" },
                {"period","4month" },
                {"price","38" },
                {"monthlyPrice", "10"},
                {"createAt","5/21/2023 10:19:34 PM" },
                {"updateAt","" }
            },
        };

        public static List<Dictionary<string, string>> teachers = new List<Dictionary<string, string>>()
        {
            new Dictionary<string, string>()
            {
                {"id","1" },
                {"name","Sok Chanvibol" },
                {"dob","2/3/1998" },
                {"maritalStatus","Marriage" },
                {"gender","Male" },
                {"hiredAt", "5/1/2023"},
                {"tel", "012345567"},
                {"email", "vibol@test.com"},
                {"createAt","5/28/2023 10:19:34 PM" },
                {"updateAt","" }
            },
            new Dictionary<string, string>()
            {
                {"id","2" },
                {"name","Sron Sreyka" },
                {"dob","2/3/2000" },
                {"maritalStatus","Single" },
                {"gender","Female" },
                {"hiredAt", "5/8/2021"},
                {"tel", "012345567"},
                {"email", "sreyka@test.com"},
                {"createAt","5/12/2021 9:19:34 PM" },
                {"updateAt","" }
            },
            new Dictionary<string, string>()
            {
                {"id","3" },
                {"name","Virak Sokchan" },
                {"dob","2/3/1999" },
                {"maritalStatus","Single" },
                {"gender","Female" },
                {"hiredAt", "1/2/2023"},
                {"tel", "012345567"},
                {"email", "sokchan@test.com"},
                {"createAt","1/13/2023 10:19:12 PM" },
                {"updateAt","" }
            },
        };
    }
}
