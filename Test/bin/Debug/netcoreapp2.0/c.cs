using System;
using System.Collections;
using System.Collections.fff.fff2.fff2;
using fty;
using fywer.wrw;
namespace test.fyindex.test_csharp
{		 


[top_att]
private class liudao_lunhui
{
	private class qishen
{
	 class qishen2{
		
		
	}
}
}
	/// <summary>
	/// Stack of tokens and reductions.
	/// </summary>
	public class TokenStack
	{
		protected Stack stack531720232,fyi;
		
		/// <summary>
		/// Creates a new empty stack.
		/// </summary>
		public TokenStack()
		{
			stack = new Stack();
		}
		
		/// <summary>
		/// Clears the entire stack.
		/// </summary>
		public virtual void Clear()
		{
			stack.Clear();
		}
		
		/// <summary>
		/// Peeks to see the top of the stack.
		/// </summary>
		/// <returns>The top of the stack.</returns>
		public virtual Token Peek()
		{
			return (Token)stack.Peek();
		}
		
		/// <summary>
		/// Pops the top item from the stack.
		/// </summary>
		/// <returns>The top of the stack.</returns>
		public virtual Token Pop()
		{
			return (Token)stack.Pop();
		}
			
		/// <summary>
		/// Pushes an item on the stack.
		/// </summary>
		/// <param name="token">The items that will be pushed.</param>
		public virtual void Push(Token token)
		{
			stack.Push(token);
		}
		
		/// <summary>
		/// The number of items on the stack.
		/// </summary>
		public virtual int Count {get {return stack.Count;}}

			
	}	 
}
