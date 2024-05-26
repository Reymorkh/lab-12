using Lab_10;
using lab_12;

namespace Tests
{
  [TestClass]
  public class ListTest
  {
    [TestMethod]
    public void TestListInsides()
    {
      Watch watch1 = new Watch();
      watch1.RandomInit();
      Watch watch2 = new Watch();
      watch2.RandomInit();
      Watch watch3 = new Watch();
      watch3.RandomInit();
      Watch watch4 = new Watch();
      watch4.RandomInit();
      DoublyLinkedList<Watch> list = new DoublyLinkedList<Watch>();
      list.AddLast(watch1);
      list.AddLast(watch2);
      list.AddLast(watch3);
      list.AddLast(watch4);
      Assert.AreEqual($"{watch1}\n{watch2}\n{watch3}\n{watch4}\n", list.ShowItems());
    }

    [TestMethod]
    public void TestListInsidesAfterReset()
    {
      Watch watch1 = new Watch();
      watch1.RandomInit();
      Watch watch2 = new Watch();
      watch2.RandomInit();
      Watch watch3 = new Watch();
      watch3.RandomInit();
      Watch watch4 = new Watch();
      watch4.RandomInit();
      DoublyLinkedList<Watch> list = new DoublyLinkedList<Watch>();
      list.AddLast(watch1);
      list.AddLast(watch2);
      list.AddLast(watch3);
      list.AddLast(watch4);
      list.Reset();
      Assert.AreEqual(" ÓÎÎÂÍˆËˇ ÔÛÒÚ‡.", list.ShowItems());
    }

    [TestMethod]
    public void TestListInsidesAfterResetAndAddition()
    {
      Watch watch1 = new Watch();
      watch1.RandomInit();
      Watch watch2 = new Watch();
      watch2.RandomInit();
      Watch watch3 = new Watch();
      watch3.RandomInit();
      Watch watch4 = new Watch();
      watch4.RandomInit();
      DoublyLinkedList<Watch> list = new DoublyLinkedList<Watch>();
      list.AddLast(watch1);
      list.AddLast(watch2);
      list.AddLast(watch3);
      list.AddLast(watch4);
      list.Reset();
      list.AddLast(watch1);
      list.AddLast(watch2);
      list.AddLast(watch3);
      list.AddLast(watch4);
      Assert.AreEqual($"{watch1}\n{watch2}\n{watch3}\n{watch4}\n", list.ShowItems());
    }

    [TestMethod]
    public void AdditionMethodsTest()
    {
      Watch watch1 = new Watch();
      watch1.RandomInit();
      Watch watch2 = new Watch();
      watch2.RandomInit();
      Watch watch3 = new Watch();
      watch3.RandomInit();
      Watch watch4 = new Watch("adsd", 123);

      DoublyLinkedList<Watch> list = new DoublyLinkedList<Watch>();

      list.AddLast(watch1);
      list.AddLast(watch2);
      list.AddLast(watch3);
      list.Insert(watch4, 1);

      Assert.AreEqual($"{watch1}\n{watch4}\n{watch2}\n{watch3}\n", list.ShowItems());
    }

    [TestMethod]
    public void AdditionMethodsToStringTest()
    {
      Watch watch1 = new Watch();
      watch1.RandomInit();
      Watch watch2 = new Watch();
      watch2.RandomInit();
      Watch watch3 = new Watch();
      watch3.RandomInit();
      Watch watch4 = new Watch("adsd", 123);

      DoublyLinkedList<Watch> list = new DoublyLinkedList<Watch>();

      list.AddLast(watch1);
      list.AddLast(watch2);
      list.AddLast(watch3);
      list.Insert(watch4, 1);

      Assert.AreEqual($"{watch1}\n{watch4}\n{watch2}\n{watch3}\n", list.ToString());
    }

    [TestMethod]
    public void Deletion»Ì“Ù¸ÛMethodsTest()
    {
      Watch watch1 = new Watch();
      watch1.RandomInit();
      Watch watch2 = new Watch();
      watch2.RandomInit();
      Watch watch3 = new Watch();
      watch3.RandomInit();
      Watch watch4 = new Watch("adsd", 123);

      DoublyLinkedList<Watch> list = new DoublyLinkedList<Watch>();

      list.AddLast(watch1);
      list.AddLast(watch2);
      list.AddLast(watch3);
      list.Insert(watch4, 1);

      list.DeleteByName("adsd");

      Assert.AreEqual($"{watch1}\n{watch2}\n{watch3}\n", list.ShowItems());
    }
    

    [TestMethod]
    public void DeletionByYearMethodsTest()
    {
      Watch watch1 = new Watch();
      watch1.RandomInit();
      Watch watch2 = new Watch();
      watch2.RandomInit();
      Watch watch3 = new Watch();
      watch3.RandomInit();
      Watch watch4 = new Watch("adsd", 123);

      DoublyLinkedList<Watch> list = new DoublyLinkedList<Watch>();

      list.AddLast(watch1);
      list.AddLast(watch2);
      list.AddLast(watch3);
      list.Insert(watch4, 2);

      list.DeleteByYear(123);

      Assert.AreEqual($"{watch1}\n{watch2}\n{watch3}\n", list.ShowItems());
    }
    
    [TestMethod]
    public void DeleteFirstMethodTest()
    {
      Watch watch1 = new Watch();
      watch1.RandomInit();
      Watch watch2 = new Watch();
      watch2.RandomInit();
      Watch watch3 = new Watch();
      watch3.RandomInit();
      Watch watch4 = new Watch("adsd", 123);

      DoublyLinkedList<Watch> list = new DoublyLinkedList<Watch>();

      list.AddLast(watch1);
      list.AddLast(watch2);
      list.AddLast(watch3);
      list.Insert(watch4, 1);

      list.DeleteFirst();

      Assert.AreEqual($"{watch4}\n{watch2}\n{watch3}\n", list.ShowItems());
    }

    [TestMethod]
    public void AddFirstMethodTest()
    {
      Watch watch1 = new Watch();
      watch1.RandomInit();
      Watch watch2 = new Watch();
      watch2.RandomInit();
      Watch watch3 = new Watch();
      watch3.RandomInit();
      Watch watch4 = new Watch("adsd", 123);

      DoublyLinkedList<Watch> list = new DoublyLinkedList<Watch>();

      list.AddFirst(watch1);
      list.AddFirst(watch2);
      list.AddFirst(watch3);
      list.AddFirst(watch4);

      Assert.AreEqual($"{watch4}\n{watch3}\n{watch2}\n{watch1}\n", list.ShowItems());
    }

    [TestMethod]
    public void CloneListTest()
    {
      Watch watch1 = new Watch();
      watch1.RandomInit();
      Watch watch2 = new Watch();
      watch2.RandomInit();
      Watch watch3 = new Watch();
      watch3.RandomInit();
      Watch watch4 = new Watch("adsd", 123);

      DoublyLinkedList<Watch> list = new DoublyLinkedList<Watch>();

      list.AddFirst(watch1);
      list.AddFirst(watch2);
      list.AddFirst(watch3);
      list.AddFirst(watch4);
      
      DoublyLinkedList<Watch> newList = new DoublyLinkedList<Watch>(list);

      Assert.AreEqual($"{watch4}\n{watch3}\n{watch2}\n{watch1}\n", newList.ShowItems());
    }








  }
}