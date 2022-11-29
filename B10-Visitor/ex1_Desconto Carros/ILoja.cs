namespace Visitor
{
    public interface ILoja
    {
        void Visit(IVisitor visitor);
    }
}