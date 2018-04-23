using System.Collections.Generic;

namespace RegistrationForm.DataModel {
    public class Gender {
        public int ID { get; private set; }
        public string Description { get; private set; }
        public Gender(int id, string description) {
            ID = id;
            Description = description;
        }
    }
    public class GenderList : List<Gender> {
        public static GenderList Source { get; private set; }

        static GenderList() {
            Source = new GenderList();
            Source.Add(new Gender(0, "Female"));
            Source.Add(new Gender(1, "Male"));
        }
    }
}
