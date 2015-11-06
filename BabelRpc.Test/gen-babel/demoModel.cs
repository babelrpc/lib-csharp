// <auto-generated />
// AUTO-GENERATED FILE - DO NOT MODIFY
// Generated from demo.babel

using System;
using System.Collections.Generic;
using System.Text;
using BabelRpc;

namespace BabelRpc.Demo
{

	/// <summary>
	///  The State shows whether logging in ON or OFF
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("Babel", "")]
	public enum State
	{
		OFF = 0,
		ON = 1
	}

	/// <summary>
	///  Logs defines constants for the various log types
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("Babel", "")]
	public sealed class Logs
	{
		public const string ErrorLog = "ErrorLog";
		public const string MessageLog = "MessageLog";
	}

	/// <summary>
	///  A joke with a question and answer
	/// </summary>
	public class Joke : IBabelModel
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public Joke()
		{ 
		}

		/// <summary>
		///  The question
		/// </summary>
		public string Question { get; set; }

		/// <summary>
		///  The answer
		/// </summary>
		[System.ComponentModel.DataAnnotations.Required]
		public string Answer { get; set; }

		/// <summary>
		///  When the joke was added
		/// </summary>
		public DateTime? DateAdded { get; set; }

		public override string ToString()
		{
			var ser = new BabelJsonSerializer();
			using(var strm = (System.IO.MemoryStream)ser.Serialize(this))
			{
				return (new UTF8Encoding(false)).GetString(strm.ToArray());
			}
		}
		#region IBabelModel
		public virtual void RunOnChildren<T>(BabelModelAction<T> method, T auxData, bool runOnAll = true)
		{
			if(method == null) throw new ArgumentNullException("method");
			if(runOnAll) Question = (string) method("Question", typeof(string), Question, auxData);
			if(runOnAll) Answer = (string) method("Answer", typeof(string), Answer, auxData);
			if(runOnAll) DateAdded = (DateTime?) method("DateAdded", typeof(DateTime?), DateAdded, auxData);

		}

		public virtual bool RunOnChild<T>(string name, BabelModelAction<T> method, T auxData)
		{
			if(method == null) throw new ArgumentNullException("method");
			switch(name)
			{
				case "Question": Question = (string) method("Question", typeof(string), Question, auxData); return true;
				case "Answer": Answer = (string) method("Answer", typeof(string), Answer, auxData); return true;
				case "DateAdded": DateAdded = (DateTime?) method("DateAdded", typeof(DateTime?), DateAdded, auxData); return true;
				default: return false;
			}
		}
		#endregion
	}

	/// <summary>
	///  The Info struct contains a map of the logging status for each type of log.
	/// </summary>
	public class Info : IBabelModel
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public Info()
		{ 
			Status = new Dictionary<string,State?>();
			Jokes = new List<Joke>();
		}

		/// <summary>
		///  Map of log types
		/// </summary>
		public Dictionary<string,State?> Status { get; set; }

		/// <summary>
		///  Jokes for your amusement
		/// </summary>
		public List<Joke> Jokes { get; set; }

		public int? LogLevel { get; set; }

		public override string ToString()
		{
			var ser = new BabelJsonSerializer();
			using(var strm = (System.IO.MemoryStream)ser.Serialize(this))
			{
				return (new UTF8Encoding(false)).GetString(strm.ToArray());
			}
		}
		#region IBabelModel
		public virtual void RunOnChildren<T>(BabelModelAction<T> method, T auxData, bool runOnAll = true)
		{
			if(method == null) throw new ArgumentNullException("method");
			Status = (Dictionary<string,State?>) method("Status", typeof(Dictionary<string,State?>), Status, auxData);
			Jokes = (List<Joke>) method("Jokes", typeof(List<Joke>), Jokes, auxData);
			if(runOnAll) LogLevel = (int?) method("logLevel", typeof(int?), LogLevel, auxData);

		}

		public virtual bool RunOnChild<T>(string name, BabelModelAction<T> method, T auxData)
		{
			if(method == null) throw new ArgumentNullException("method");
			switch(name)
			{
				case "Status": Status = (Dictionary<string,State?>) method("Status", typeof(Dictionary<string,State?>), Status, auxData); return true;
				case "Jokes": Jokes = (List<Joke>) method("Jokes", typeof(List<Joke>), Jokes, auxData); return true;
				case "logLevel": LogLevel = (int?) method("logLevel", typeof(int?), LogLevel, auxData); return true;
				default: return false;
			}
		}
		#endregion
	}

} 
