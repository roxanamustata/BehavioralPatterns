namespace VisitorPattern
{
    public class Shape : IVisitable
    {

        public void Accept(IVisitor visitor) {
            visitor.Visit(this);

        }
        
    }
}
