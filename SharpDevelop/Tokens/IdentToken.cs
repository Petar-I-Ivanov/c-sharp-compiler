using System.Text;

namespace scsc
{
	public class IdentToken: Token
	{
		public string value;
		public LiteralToken literal;
		
		public IdentToken(int line, int column, string value, LiteralToken literal = null): base(line, column) {
			this.value = value;
			this.literal = literal;
		}
		
		public override string ToString()
		{
			StringBuilder s = new StringBuilder();
			s.AppendFormat("line {0}, column {1}: {2} - {3}", line, column, value, GetType());
			return s.ToString();
		}
	}
}
