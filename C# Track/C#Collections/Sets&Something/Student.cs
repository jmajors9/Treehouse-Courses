namespace Treehouse
{
    class Student : System.IComparable<Student>
    {
        public string Name { get; set; }
        public int GradeLevel { get; set; }
 
        public int CompareTo(Student that)
        {
            int result = Name.CompareTo(that.Name);
            
            if(result == 0)
            {
                result = GradeLevel.CompareTo(that.GradeLevel);
            }
            
            return result;
        }

    #region Added in Video 1    
        public override int GetHashCode()
            {            

                /*
                Name.GetHashCode()
                GradeLevel.GetHashCode()
                //two integers above, can only return one.
                // let's combine them and get a unique integer
                */

                return Name.GetHashCode() + GradeLevel.GetHashCode();
            }
    #endregion

    #region Added in Video 2
        public override bool Equals(object obj)
            {
                var Student that = obj as Student;
                // if obj isn't a student, returns null

                if(that == null)
                {
                    return false;
                }

                return this.Name == that.Name && this.GradeLevel == that.GradeLevel;

                // throw new System.NotImplementedException();
            }
        //now they both will share a hashcode and return ok.

    #endregion


    }
}