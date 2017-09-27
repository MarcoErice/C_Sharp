namespace StudentCountApp
{
    internal class Class
    {
        public int numberOfStudents;

        public Class(int numberOfStudents)
        {
            this.numberOfStudents = numberOfStudents;
        }
        public override string ToString()
        {
            return this.numberOfStudents.ToString();
        }
    }
}