using Xunit;
using TodoApp;
using System;

namespace TestProject1
{
    public class UnitTest1
    {
        private readonly ItemService _service;

        public UnitTest1()
        {
            _service = new ItemService();
        }

        

        [Fact]
        public void Add_ValidTitle_ShouldAddItem()
        {
       
            var item = _service.Add("Зробити звіт");

         
            Assert.Contains(item, _service.GetAll());
        }

        [Fact]
        public void Complete_ExistingId_ShouldMarkAsDone()
        {
         
            var item = _service.Add("Завдання");

         
            _service.Complete(item.Id);

       
            Assert.True(item.IsCompleted);
        }


        [Fact]
        public void Add_EmptyTitle_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => _service.Add(""));
        }

        [Fact]
        public void Complete_InvalidId_ShouldThrowException()
        {

            Assert.Throws<Exception>(() => _service.Complete(999));
        }

        [Fact]
        public void Delete_InvalidId_ShouldThrowException()
        {
   
            Assert.Throws<Exception>(() => _service.Delete(888));
        }
    }
}