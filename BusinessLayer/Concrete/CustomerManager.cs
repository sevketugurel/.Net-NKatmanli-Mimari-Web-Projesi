using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerDal
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Delete(Customer t)
        {
            _customerDal.Delete(t);
        }

        public Customer GetByID(int id)
        {
            return _customerDal.GetByID(id);
        }

        public List<Customer> GetList()
        {
            return _customerDal.GetList();
        }

        public void Insert(Customer t)
        {
            _customerDal.Insert(t);
        }

        public void Update(Customer t)
        {
            _customerDal.Update(t);
        }
    }
}