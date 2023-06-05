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

        public static List<Dictionary<string, string>> students = new List<Dictionary<string, string>>()
        {
            new Dictionary<string, string>()
            {
                {"id","1" },
                {"name","Khim Pich" },
                {"dob","2/3/2004" },
                {"gender","Male" },
                {"tel", "012345567"},
                {"email", "pich@test.com"},
                {"createAt","5/31/2023 10:19:34 PM" },
                {"updateAt","" }
            },
            new Dictionary<string, string>()
            {
                {"id","2" },
                {"name","Sok Virak" },
                {"dob","5/1/2001" },
                {"gender","Male" },
                {"tel", "012345567"},
                {"email", "virak@test.com"},
                {"createAt","5/21/2023 10:20:34 PM" },
                {"updateAt","" }
            },
            new Dictionary<string, string>()
            {
                {"id","3" },
                {"name","Chan Tina" },
                {"dob","3/9/2002" },
                {"gender","Female" },
                {"tel", "012345567"},
                {"email", "tina@test.com"},
                {"createAt","5/12/2023 10:19:34 PM" },
                {"updateAt","" }
            }
        };

        public static List<Dictionary<string, string>> rooms = new List<Dictionary<string, string>>()
        {
            new Dictionary<string, string>()
            {
                {"id","1" },
                {"name","1A" },
                {"type","Computer Classrooms" },
                {"floor","1" },
                {"createAt","5/31/2023 10:19:34 PM" },
                {"updateAt","" }
            },
            new Dictionary<string, string>()
            {
                {"id","2" },
                {"name","3B" },
                {"type","Lecture Classrooms" },
                {"floor","3" },
                {"createAt","5/31/2023 10:19:34 PM" },
                {"updateAt","" }
            },
            new Dictionary<string, string>()
            {
                {"id","3" },
                {"name","1B" },
                {"type","Computer Classrooms" },
                {"floor","1" },
                {"createAt","5/31/2023 10:19:34 PM" },
                {"updateAt","" }
            }
        };

        public static List<Dictionary<string, string>> classes = new List<Dictionary<string, string>>()
        {
            new Dictionary<string, string>()
            {
                {"id","1" },
                {"courseId","3" },
                {"roomId","2" },
                {"teacherId","1" },
                {"time","2:30pm - 3:30pm" },
                {"createAt","5/31/2023 10:19:34 PM" },
                {"updateAt","" }
            },
            new Dictionary<string, string>()
            {
                {"id","2" },
                {"courseId","1" },
                {"roomId","3" },
                {"teacherId","2" },
                {"time","5:30pm - 6:30pm" },
                {"createAt","5/31/2023 10:19:34 PM" },
                {"updateAt","" }
            },
            new Dictionary<string, string>()
            {
                {"id","3" },
                {"courseId","1" },
                {"roomId","1" },
                {"teacherId","3" },
                {"time","2:30pm - 3:30pm" },
                {"createAt","5/31/2023 10:19:34 PM" },
                {"updateAt","" }
            }
        };

        public static List<Dictionary<string, string>> payments = new List<Dictionary<string, string>>()
        {
            new Dictionary<string, string>()
            {
                {"id","1" },
                {"stId","1" },
                {"classId","1" },
                {"price","10" },
                {"discount","0%" },
                {"paidAt","5/21/2023 10:19:34 PM" },
                {"rep","SOPHEAK" }
            },
            new Dictionary<string, string>()
            {
                {"id","2" },
                {"stId","2" },
                {"classId","1" },
                {"price","10" },
                {"discount","0%" },
                {"paidAt","5/21/2023 1:19:34 PM" },
                {"rep","SOPHEAK" }
            },
            new Dictionary<string, string>()
            {
                {"id","3" },
                {"stId","3" },
                {"classId","1" },
                {"price","10" },
                {"discount","0%" },
                {"paidAt","5/23/2023 9:19:34 AM" },
                {"rep","SOPHEAK" }
            }
        };
        public static List<Dictionary<string, string>> attendance = new List<Dictionary<string, string>>()
        {
            new Dictionary<string, string>()
            {
                {"id","1" },
                {"stId","1" },
                {"classId","1" },
                {"hasPermission","t" },
                {"date","Thursday, June 1, 2023" },
            },
            new Dictionary<string, string>()
            {
                {"id","1" },
                {"stId","2" },
                {"classId","1" },
                {"hasPermission","f" },
                {"date","Friday, June 2, 2023" },
            }
        };
    }
}
