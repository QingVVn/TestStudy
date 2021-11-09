namespace TestStudy.Dummy
{
    public class Mark
    {
        private Student _student;
        private readonly decimal _mark;

        public Mark(Student student, decimal mark)
        {
            this._student = student;
            this._mark = mark;
        }

        public decimal GetMark()
        {
            return _mark;
        }
    }
}