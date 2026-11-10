
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Adicionar três pessoas com prioridades diferentes.
    // Expected Result: Deve retornar a pessoa com maior prioridade.
    // Defect(s) Found: O código poderia ignorar o último item da fila.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

            priorityQueue.Enqueue("Ana", 3);
            priorityQueue.Enqueue("Maria", 4);
            priorityQueue.Enqueue("Joao", 7);

        string result = priorityQueue.Dequeue();

        Assert.AreEqual("Joao", result);
    }

    [TestMethod]
    // Scenario: Retirar dois itens da fila.
    // Expected Result: Deve retornar João e depois Maria.
    // Defect(s) Found: O código poderia retornar o item sem removê-lo.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Ana", 3);
        priorityQueue.Enqueue("Joao", 7);
        priorityQueue.Enqueue("Maria", 4);

        string firstResult = priorityQueue.Dequeue();
        string secondResult = priorityQueue.Dequeue();

        Assert.AreEqual("Joao", firstResult);
        Assert.AreEqual("Maria", secondResult);
    }

    [TestMethod]
    // Scenario: Tentar retirar um item de uma fila vazia.
    // Expected Result: Deve lançar InvalidOperationException.
    // Defect(s) Found: Verificar o tratamento de fila vazia.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        var ex = Assert.ThrowsException<InvalidOperationException>(
            () => priorityQueue.Dequeue()
        );
        Assert.AreEqual("The queue is empty.", ex.Message);
    }

        [TestMethod]
    // Scenario: Dois itens com a mesma prioridade mais alta.
    // Expected Result: Sai o que entrou primeiro (Ana).
    // Defect(s) Found: 
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Ana", 5);
        priorityQueue.Enqueue("Joao", 5);
        priorityQueue.Enqueue("Maria", 1);

        Assert.AreEqual("Ana", priorityQueue.Dequeue());
    }
}
