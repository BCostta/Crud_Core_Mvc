namespace Crud_Core_Mvc.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {

        public NotFoundException(string message) : base(message) 
        {
        }

    }
}
