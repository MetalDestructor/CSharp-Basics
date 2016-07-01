namespace Cosmetics.Exceptions
{
    using System;
    class CategoryOutOfRangeException:ArgumentOutOfRangeException
    {
        public CategoryOutOfRangeException(string message, int min, int max) :base(message)
        {

        }
    }
}
