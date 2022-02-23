namespace HackerRankPractice.Other
{
	public sealed class LinkedList
	{
		#region Public Fields

		public Node FirstNode;

		#endregion

		#region Constructors

		public LinkedList(int nodeCount)
		{
			FirstNode = new Node();
			Node currentNode = FirstNode;
			
			for (int index = 0; index < nodeCount - 1; index++)
			{
				currentNode.Next = new Node();
				currentNode = currentNode.Next;
				currentNode.Data = index;
			}
		}

		#endregion

		#region Public Methods

		public static int GetNodeCount(Node head)
		{
			if (head == null) return 0;
			
			int nodeCount = 0;
			Node currentNode = head;

			while (currentNode != null)
			{
				nodeCount++;
				currentNode = currentNode.Next;
			}

			return nodeCount;
		}

		#endregion
	}
}