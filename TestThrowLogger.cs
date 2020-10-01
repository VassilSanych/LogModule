using System;
using System.Threading.Tasks;
using NLog;

namespace VGn.LogModule
{
	/// <summary>
	///  Логер для использования в блочных тестах. Все события выводит в консоль.
	/// </summary>
    // ReSharper disable once UnusedMember.Global
    public class TestThrowLogger : ILogger
    {
		public Action<string> InfoAction { get; set; } = Console.WriteLine;
		public Action<string> TraceAction { get; set; } = Console.WriteLine;
		public Action<string> DebugAction { get; set; } = (str) => throw new DebugException(str);
        public Action<string> WarnAction { get; set; } = (str) => throw new WarnException(str);
        public Action<string> ErrorAction { get; set; } = (str) => throw new ErrorException(str);
		public Action<string> FatalAction { get; set; } = (str) => throw new ErrorException(str);

        public void Log(LogLevel level, object value)
        {
            Console.WriteLine(Convert.ToString(value));
        }

        public void Log(LogLevel level, IFormatProvider formatProvider, object value)
        {
            Console.WriteLine(Convert.ToString(value));
        }

        public void Log(LogLevel level, string message, object arg1, object arg2)
        {
            Console.WriteLine($"{message} {Convert.ToString(arg1)} {Convert.ToString(arg1)}");
        }

        public void Log(LogLevel level, string message, object arg1, object arg2, object arg3)
        {
            Console.WriteLine($"{message} {Convert.ToString(arg1)} {Convert.ToString(arg1)} {Convert.ToString(arg3)}");
        }

        public void Log(LogLevel level, IFormatProvider formatProvider, string message, bool argument)
        {
            Console.WriteLine(message);
        }

        public void Log(LogLevel level, string message, bool argument)
        {
            Console.WriteLine(message);
        }

        public void Log(LogLevel level, IFormatProvider formatProvider, string message, char argument)
        {
            Console.WriteLine(message);
        }

        public void Log(LogLevel level, string message, char argument)
        {
            Console.WriteLine(message);
        }

        public void Log(LogLevel level, IFormatProvider formatProvider, string message, byte argument)
        {
            Console.WriteLine(message);
        }

        public void Log(LogLevel level, string message, byte argument)
        {
            Console.WriteLine(message);
        }

        public void Log(LogLevel level, IFormatProvider formatProvider, string message, string argument)
        {
            Console.WriteLine(message);
        }

        public void Log(LogLevel level, string message, string argument)
        {
            Console.WriteLine(message);
        }

        public void Log(LogLevel level, IFormatProvider formatProvider, string message, int argument)
        {
            Console.WriteLine(message);
        }

        public void Log(LogLevel level, string message, int argument)
        {
            Console.WriteLine(message);
        }

        public void Log(LogLevel level, IFormatProvider formatProvider, string message, long argument)
        {
            Console.WriteLine(message);
        }

        public void Log(LogLevel level, string message, long argument)
        {
            Console.WriteLine(message);
        }

        public void Log(LogLevel level, IFormatProvider formatProvider, string message, float argument)
        {
            Console.WriteLine(message);
        }

        public void Log(LogLevel level, string message, float argument)
        {
            Console.WriteLine(message);
        }

        public void Log(LogLevel level, IFormatProvider formatProvider, string message, double argument)
        {
            Console.WriteLine(message);
        }

        public void Log(LogLevel level, string message, double argument)
        {
            Console.WriteLine(message);
        }

        public void Log(LogLevel level, IFormatProvider formatProvider, string message, decimal argument)
        {
            Console.WriteLine(message);
        }

        public void Log(LogLevel level, string message, decimal argument)
        {
            Console.WriteLine(message);
        }

        public void Log(LogLevel level, IFormatProvider formatProvider, string message, object argument)
        {
            Console.WriteLine(message);
        }

        public void Log(LogLevel level, string message, object argument)
        {
            Console.WriteLine(message);
        }

        public void Log(LogLevel level, IFormatProvider formatProvider, string message, sbyte argument)
        {
            Console.WriteLine(message);
        }

        public void Log(LogLevel level, string message, sbyte argument)
        {
            Console.WriteLine(message);
        }

        public void Log(LogLevel level, IFormatProvider formatProvider, string message, uint argument)
        {
            Console.WriteLine(message);
        }

        public void Log(LogLevel level, string message, uint argument)
        {
            Console.WriteLine(message);
        }

        public void Log(LogLevel level, IFormatProvider formatProvider, string message, ulong argument)
        {
            Console.WriteLine(message);
        }

        public void Log(LogLevel level, string message, ulong argument)
        {
            Console.WriteLine(message);
        }

        public bool IsEnabled(LogLevel level)
        {
            return true;
        }

        public void Log(LogEventInfo logEvent)
        {
            Console.WriteLine(logEvent.Message);
        }

        public void Log(Type wrapperType, LogEventInfo logEvent)
        {
            Console.WriteLine(logEvent.Message);
        }

        public void Log<T>(LogLevel level, T value)
        {
            Console.WriteLine(Convert.ToString(value));
        }

        public void Log<T>(LogLevel level, IFormatProvider formatProvider, T value)
        {
            Console.WriteLine(Convert.ToString(value));
        }

        public void Log(LogLevel level, LogMessageGenerator messageFunc)
        {
            Console.WriteLine(messageFunc.Invoke());
        }

        public void LogException(LogLevel level, string message, Exception exception)
        {
            Console.WriteLine(message);
        }

        public void Log(LogLevel level, Exception exception, string message, params object[] args)
        {
            Console.WriteLine(message);
        }

        public void Log(LogLevel level, Exception exception, IFormatProvider formatProvider, string message, params object[] args)
        {
            Console.WriteLine(message);
        }

        public void Log(LogLevel level, IFormatProvider formatProvider, string message, params object[] args)
        {
            Console.WriteLine(message);
        }

        public void Log(LogLevel level, string message)
        {
            Console.WriteLine(message);
        }

        public void Log(LogLevel level, string message, params object[] args)
        {
            Console.WriteLine(message);
        }

        public void Log(LogLevel level, string message, Exception exception)
        {
            Console.WriteLine(message);
        }

        public void Log<TArgument>(LogLevel level, IFormatProvider formatProvider, string message, TArgument argument)
        {
            Console.WriteLine(message);
        }

        public void Log<TArgument>(LogLevel level, string message, TArgument argument)
        {
            Console.WriteLine(message);
        }

        public void Log<TArgument1, TArgument2>(LogLevel level, IFormatProvider formatProvider, string message, TArgument1 argument1,
            TArgument2 argument2)
        {
            Console.WriteLine(message);
        }

        public void Log<TArgument1, TArgument2>(LogLevel level, string message, TArgument1 argument1, TArgument2 argument2)
        {
            Console.WriteLine(message);
        }

        public void Log<TArgument1, TArgument2, TArgument3>(LogLevel level, IFormatProvider formatProvider, string message,
            TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {
            Console.WriteLine(message);
        }

        public void Log<TArgument1, TArgument2, TArgument3>(LogLevel level, string message, TArgument1 argument1, TArgument2 argument2,
            TArgument3 argument3)
        {
            Console.WriteLine(message);
        }

        public string Name { get; }
        public LogFactory Factory { get; }
        public event EventHandler<EventArgs> LoggerReconfigured;
        public void Swallow(Action action)
        {
            action.Invoke();
        }

        public T Swallow<T>(Func<T> func)
        {
            return func.Invoke();
        }

        public T Swallow<T>(Func<T> func, T fallback)
        {
            return func.Invoke();
        }

        public void Swallow(Task task)
        {
            task.Wait();
        }

        public async Task SwallowAsync(Task task)
        {
            await task;
        }

        public async Task SwallowAsync(Func<Task> asyncAction)
        {
            await asyncAction.Invoke();
        }

        public async Task<TResult> SwallowAsync<TResult>(Func<Task<TResult>> asyncFunc)
        {
            return await asyncFunc.Invoke();
        }

        public async Task<TResult> SwallowAsync<TResult>(Func<Task<TResult>> asyncFunc, TResult fallback)
        {
            return await asyncFunc.Invoke();
        }

        public void Trace(object value)
        {
            Console.WriteLine(Convert.ToString(value));
        }

        public void Trace(IFormatProvider formatProvider, object value)
        {
            Console.WriteLine(Convert.ToString(value));
        }

        public void Trace(string message, object arg1, object arg2)
        {
            Console.WriteLine(message);
        }

        public void Trace(string message, object arg1, object arg2, object arg3)
        {
            Console.WriteLine(message);
        }

        public void Trace(IFormatProvider formatProvider, string message, bool argument)
        {
            Console.WriteLine(message);
        }

        public void Trace(string message, bool argument)
        {
            Console.WriteLine(message);
        }

        public void Trace(IFormatProvider formatProvider, string message, char argument)
        {
            Console.WriteLine(message);
        }

        public void Trace(string message, char argument)
        {
            Console.WriteLine(message);
        }

        public void Trace(IFormatProvider formatProvider, string message, byte argument)
        {
            Console.WriteLine(message);
        }

        public void Trace(string message, byte argument)
        {
            Console.WriteLine(message);
        }

        public void Trace(IFormatProvider formatProvider, string message, string argument)
        {
            Console.WriteLine(message);
        }

        public void Trace(string message, string argument)
        {
            Console.WriteLine(message);
        }

        public void Trace(IFormatProvider formatProvider, string message, int argument)
        {
            Console.WriteLine(message);
        }

        public void Trace(string message, int argument)
        {
            Console.WriteLine(message);
        }

        public void Trace(IFormatProvider formatProvider, string message, long argument)
        {
            Console.WriteLine(message);
        }

        public void Trace(string message, long argument)
        {
            Console.WriteLine(message);
        }

        public void Trace(IFormatProvider formatProvider, string message, float argument)
        {
            Console.WriteLine(message);
        }

        public void Trace(string message, float argument)
        {
            Console.WriteLine(message);
        }

        public void Trace(IFormatProvider formatProvider, string message, double argument)
        {
            Console.WriteLine(message);
        }

        public void Trace(string message, double argument)
        {
            Console.WriteLine(message);
        }

        public void Trace(IFormatProvider formatProvider, string message, decimal argument)
        {
            Console.WriteLine(message);
        }

        public void Trace(string message, decimal argument)
        {
            Console.WriteLine(message);
        }

        public void Trace(IFormatProvider formatProvider, string message, object argument)
        {
            Console.WriteLine(message);
        }

        public void Trace(string message, object argument)
        {
            Console.WriteLine(message);
        }

        public void Trace(IFormatProvider formatProvider, string message, sbyte argument)
        {
            Console.WriteLine(message);
        }

        public void Trace(string message, sbyte argument)
        {
            Console.WriteLine(message);
        }

        public void Trace(IFormatProvider formatProvider, string message, uint argument)
        {
            Console.WriteLine(message);
        }

        public void Trace(string message, uint argument)
        {
            Console.WriteLine(message);
        }

        public void Trace(IFormatProvider formatProvider, string message, ulong argument)
        {
            Console.WriteLine(message);
        }

        public void Trace(string message, ulong argument)
        {
            Console.WriteLine(message);
        }

        public void Debug(object value)
        {
            DebugAction(Convert.ToString(value));
        }

        public void Debug(IFormatProvider formatProvider, object value)
        {
            DebugAction(Convert.ToString(value));
        }

        public void Debug(string message, object arg1, object arg2)
        {
            DebugAction(message);
        }

        public void Debug(string message, object arg1, object arg2, object arg3)
        {
            DebugAction(message);
        }

        public void Debug(IFormatProvider formatProvider, string message, bool argument)
        {
            DebugAction(message);
        }

        public void Debug(string message, bool argument)
        {
            DebugAction(message);
        }

        public void Debug(IFormatProvider formatProvider, string message, char argument)
        {
            DebugAction(message);
        }

        public void Debug(string message, char argument)
        {
            DebugAction(message);
        }

        public void Debug(IFormatProvider formatProvider, string message, byte argument)
        {
            DebugAction(message);
        }

        public void Debug(string message, byte argument)
        {
            DebugAction(message);
        }

        public void Debug(IFormatProvider formatProvider, string message, string argument)
        {
            DebugAction(message);
        }

        public void Debug(string message, string argument)
        {
            DebugAction(message);
        }

        public void Debug(IFormatProvider formatProvider, string message, int argument)
        {
            DebugAction(message);
        }

        public void Debug(string message, int argument)
        {
            DebugAction(message);
        }

        public void Debug(IFormatProvider formatProvider, string message, long argument)
        {
            DebugAction(message);
        }

        public void Debug(string message, long argument)
        {
            DebugAction(message);
        }

        public void Debug(IFormatProvider formatProvider, string message, float argument)
        {
            DebugAction(message);
        }

        public void Debug(string message, float argument)
        {
            DebugAction(message);
        }

        public void Debug(IFormatProvider formatProvider, string message, double argument)
        {
            DebugAction(message);
        }

        public void Debug(string message, double argument)
        {
            DebugAction(message);
        }

        public void Debug(IFormatProvider formatProvider, string message, decimal argument)
        {
            DebugAction(message);
        }

        public void Debug(string message, decimal argument)
        {
            DebugAction(message);
        }

        public void Debug(IFormatProvider formatProvider, string message, object argument)
        {
            DebugAction(message);
        }

        public void Debug(string message, object argument)
        {
            DebugAction(message);
        }

        public void Debug(IFormatProvider formatProvider, string message, sbyte argument)
        {
            DebugAction(message);
        }

        public void Debug(string message, sbyte argument)
        {
            DebugAction(message);
        }

        public void Debug(IFormatProvider formatProvider, string message, uint argument)
        {
            DebugAction(message);
        }

        public void Debug(string message, uint argument)
        {
            DebugAction(message);
        }

        public void Debug(IFormatProvider formatProvider, string message, ulong argument)
        {
            DebugAction(message);
        }

        public void Debug(string message, ulong argument)
        {
            DebugAction(message);
        }

        public void Info(object value)
        {
            Console.WriteLine(Convert.ToString(value));
        }

        public void Info(IFormatProvider formatProvider, object value)
        {
            Console.WriteLine(Convert.ToString(value));
        }

        public void Info(string message, object arg1, object arg2)
        {
            Console.WriteLine(message);
        }

        public void Info(string message, object arg1, object arg2, object arg3)
        {
            Console.WriteLine(message);
        }

        public void Info(IFormatProvider formatProvider, string message, bool argument)
        {
            Console.WriteLine(message);
        }

        public void Info(string message, bool argument)
        {
            Console.WriteLine(message);
        }

        public void Info(IFormatProvider formatProvider, string message, char argument)
        {
            Console.WriteLine(message);
        }

        public void Info(string message, char argument)
        {
            Console.WriteLine(message);
        }

        public void Info(IFormatProvider formatProvider, string message, byte argument)
        {
            Console.WriteLine(message);
        }

        public void Info(string message, byte argument)
        {
            Console.WriteLine(message);
        }

        public void Info(IFormatProvider formatProvider, string message, string argument)
        {
            Console.WriteLine(message);
        }

        public void Info(string message, string argument)
        {
            Console.WriteLine(message);
        }

        public void Info(IFormatProvider formatProvider, string message, int argument)
        {
            Console.WriteLine(message);
        }

        public void Info(string message, int argument)
        {
            Console.WriteLine(message);
        }

        public void Info(IFormatProvider formatProvider, string message, long argument)
        {
            Console.WriteLine(message);
        }

        public void Info(string message, long argument)
        {
            Console.WriteLine(message);
        }

        public void Info(IFormatProvider formatProvider, string message, float argument)
        {
            Console.WriteLine(message);
        }

        public void Info(string message, float argument)
        {
            Console.WriteLine(message);
        }

        public void Info(IFormatProvider formatProvider, string message, double argument)
        {
            Console.WriteLine(message);
        }

        public void Info(string message, double argument)
        {
            Console.WriteLine(message);
        }

        public void Info(IFormatProvider formatProvider, string message, decimal argument)
        {
            Console.WriteLine(message);
        }

        public void Info(string message, decimal argument)
        {
            Console.WriteLine(message);
        }

        public void Info(IFormatProvider formatProvider, string message, object argument)
        {
            Console.WriteLine(message);
        }

        public void Info(string message, object argument)
        {
            Console.WriteLine(message);
        }

        public void Info(IFormatProvider formatProvider, string message, sbyte argument)
        {
            Console.WriteLine(message);
        }

        public void Info(string message, sbyte argument)
        {
            Console.WriteLine(message);
        }

        public void Info(IFormatProvider formatProvider, string message, uint argument)
        {
            Console.WriteLine(message);
        }

        public void Info(string message, uint argument)
        {
            Console.WriteLine(message);
        }

        public void Info(IFormatProvider formatProvider, string message, ulong argument)
        {
            Console.WriteLine(message);
        }

        public void Info(string message, ulong argument)
        {
            Console.WriteLine(message);
        }

        public void Warn(object value)
        {
            WarnAction(Convert.ToString(value));
        }

        public void Warn(IFormatProvider formatProvider, object value)
        {
            WarnAction(Convert.ToString(value));
        }

        public void Warn(string message, object arg1, object arg2)
        {
            WarnAction(message);
        }

        public void Warn(string message, object arg1, object arg2, object arg3)
        {
            WarnAction(message);
        }

        public void Warn(IFormatProvider formatProvider, string message, bool argument)
        {
            WarnAction(message);
        }

        public void Warn(string message, bool argument)
        {
            WarnAction(message);
        }

        public void Warn(IFormatProvider formatProvider, string message, char argument)
        {
            WarnAction(message);
        }

        public void Warn(string message, char argument)
        {
            WarnAction(message);
        }

        public void Warn(IFormatProvider formatProvider, string message, byte argument)
        {
            WarnAction(message);
        }

        public void Warn(string message, byte argument)
        {
            WarnAction(message);
        }

        public void Warn(IFormatProvider formatProvider, string message, string argument)
        {
            WarnAction(message);
        }

        public void Warn(string message, string argument)
        {
            WarnAction(message);
        }

        public void Warn(IFormatProvider formatProvider, string message, int argument)
        {
            WarnAction(message);
        }

        public void Warn(string message, int argument)
        {
            WarnAction(message);
        }

        public void Warn(IFormatProvider formatProvider, string message, long argument)
        {
            WarnAction(message);
        }

        public void Warn(string message, long argument)
        {
            WarnAction(message);
        }

        public void Warn(IFormatProvider formatProvider, string message, float argument)
        {
            WarnAction(message);
        }

        public void Warn(string message, float argument)
        {
            WarnAction(message);
        }

        public void Warn(IFormatProvider formatProvider, string message, double argument)
        {
            WarnAction(message);
        }

        public void Warn(string message, double argument)
        {
            WarnAction(message);
        }

        public void Warn(IFormatProvider formatProvider, string message, decimal argument)
        {
            WarnAction(message);
        }

        public void Warn(string message, decimal argument)
        {
            WarnAction(message);
        }

        public void Warn(IFormatProvider formatProvider, string message, object argument)
        {
            WarnAction(message);
        }

        public void Warn(string message, object argument)
        {
            WarnAction(message);
        }

        public void Warn(IFormatProvider formatProvider, string message, sbyte argument)
        {
            WarnAction(message);
        }

        public void Warn(string message, sbyte argument)
        {
            WarnAction(message);
        }

        public void Warn(IFormatProvider formatProvider, string message, uint argument)
        {
            WarnAction(message);
        }

        public void Warn(string message, uint argument)
        {
            WarnAction(message);
        }

        public void Warn(IFormatProvider formatProvider, string message, ulong argument)
        {
            WarnAction(message);
        }

        public void Warn(string message, ulong argument)
        {
            WarnAction(message);
        }

        public void Error(object value)
        {
            ErrorAction(Convert.ToString(value));
        }

        public void Error(IFormatProvider formatProvider, object value)
        {
            ErrorAction(Convert.ToString(value));
        }

        public void Error(string message, object arg1, object arg2)
        {
            ErrorAction(message);
        }

        public void Error(string message, object arg1, object arg2, object arg3)
        {
            ErrorAction(message);
        }

        public void Error(IFormatProvider formatProvider, string message, bool argument)
        {
            ErrorAction(message);
        }

        public void Error(string message, bool argument)
        {
            ErrorAction(message);
        }

        public void Error(IFormatProvider formatProvider, string message, char argument)
        {
            ErrorAction(message);
        }

        public void Error(string message, char argument)
        {
            ErrorAction(message);
        }

        public void Error(IFormatProvider formatProvider, string message, byte argument)
        {
            ErrorAction(message);
        }

        public void Error(string message, byte argument)
        {
            ErrorAction(message);
        }

        public void Error(IFormatProvider formatProvider, string message, string argument)
        {
            ErrorAction(message);
        }

        public void Error(string message, string argument)
        {
            ErrorAction(message);
        }

        public void Error(IFormatProvider formatProvider, string message, int argument)
        {
            ErrorAction(message);
        }

        public void Error(string message, int argument)
        {
            ErrorAction(message);
        }

        public void Error(IFormatProvider formatProvider, string message, long argument)
        {
            ErrorAction(message);
        }

        public void Error(string message, long argument)
        {
            ErrorAction(message);
        }

        public void Error(IFormatProvider formatProvider, string message, float argument)
        {
            ErrorAction(message);
        }

        public void Error(string message, float argument)
        {
            ErrorAction(message);
        }

        public void Error(IFormatProvider formatProvider, string message, double argument)
        {
            ErrorAction(message);
        }

        public void Error(string message, double argument)
        {
            ErrorAction(message);
        }

        public void Error(IFormatProvider formatProvider, string message, decimal argument)
        {
            ErrorAction(message);
        }

        public void Error(string message, decimal argument)
        {
            ErrorAction(message);
        }

        public void Error(IFormatProvider formatProvider, string message, object argument)
        {
            ErrorAction(message);
        }

        public void Error(string message, object argument)
        {
            ErrorAction(message);
        }

        public void Error(IFormatProvider formatProvider, string message, sbyte argument)
        {
            ErrorAction(message);
        }

        public void Error(string message, sbyte argument)
        {
            ErrorAction(message);
        }

        public void Error(IFormatProvider formatProvider, string message, uint argument)
        {
            ErrorAction(message);
        }

        public void Error(string message, uint argument)
        {
            ErrorAction(message);
        }

        public void Error(IFormatProvider formatProvider, string message, ulong argument)
        {
            ErrorAction(message);
        }

        public void Error(string message, ulong argument)
        {
            ErrorAction(message);
        }

        public void Fatal(object value)
        {
            FatalAction(Convert.ToString(value));
        }

        public void Fatal(IFormatProvider formatProvider, object value)
        {
            FatalAction(Convert.ToString(value));
        }

        public void Fatal(string message, object arg1, object arg2)
        {
            FatalAction(message);
        }

        public void Fatal(string message, object arg1, object arg2, object arg3)
        {
            FatalAction(message);
        }

        public void Fatal(IFormatProvider formatProvider, string message, bool argument)
        {
            FatalAction(message);
        }

        public void Fatal(string message, bool argument)
        {
            FatalAction(message);
        }

        public void Fatal(IFormatProvider formatProvider, string message, char argument)
        {
            FatalAction(message);
        }

        public void Fatal(string message, char argument)
        {
            FatalAction(message);
        }

        public void Fatal(IFormatProvider formatProvider, string message, byte argument)
        {
            FatalAction(message);
        }

        public void Fatal(string message, byte argument)
        {
            FatalAction(message);
        }

        public void Fatal(IFormatProvider formatProvider, string message, string argument)
        {
            FatalAction(message);
        }

        public void Fatal(string message, string argument)
        {
            FatalAction(message);
        }

        public void Fatal(IFormatProvider formatProvider, string message, int argument)
        {
            FatalAction(message);
        }

        public void Fatal(string message, int argument)
        {
            FatalAction(message);
        }

        public void Fatal(IFormatProvider formatProvider, string message, long argument)
        {
            FatalAction(message);
        }

        public void Fatal(string message, long argument)
        {
            FatalAction(message);
        }

        public void Fatal(IFormatProvider formatProvider, string message, float argument)
        {
            FatalAction(message);
        }

        public void Fatal(string message, float argument)
        {
            FatalAction(message);
        }

        public void Fatal(IFormatProvider formatProvider, string message, double argument)
        {
            FatalAction(message);
        }

        public void Fatal(string message, double argument)
        {
            FatalAction(message);
        }

        public void Fatal(IFormatProvider formatProvider, string message, decimal argument)
        {
            FatalAction(message);
        }

        public void Fatal(string message, decimal argument)
        {
            FatalAction(message);
        }

        public void Fatal(IFormatProvider formatProvider, string message, object argument)
        {
            FatalAction(message);
        }

        public void Fatal(string message, object argument)
        {
            FatalAction(message);
        }

        public void Fatal(IFormatProvider formatProvider, string message, sbyte argument)
        {
            FatalAction(message);
        }

        public void Fatal(string message, sbyte argument)
        {
            FatalAction(message);
        }

        public void Fatal(IFormatProvider formatProvider, string message, uint argument)
        {
            FatalAction(message);
        }

        public void Fatal(string message, uint argument)
        {
            FatalAction(message);
        }

        public void Fatal(IFormatProvider formatProvider, string message, ulong argument)
        {
            FatalAction(message);
        }

        public void Fatal(string message, ulong argument)
        {
            FatalAction(message);
        }

        public void Trace<T>(T value)
        {
            Console.WriteLine(Convert.ToString(value));
        }

        public void Trace<T>(IFormatProvider formatProvider, T value)
        {
            Console.WriteLine(Convert.ToString(value));
        }

        public void Trace(LogMessageGenerator messageFunc)
        {
            Console.WriteLine(messageFunc.Invoke());
        }

        public void TraceException(string message, Exception exception)
        {
            Console.WriteLine(message);
        }

        public void Trace(Exception exception, string message)
        {
            Console.WriteLine(message);
        }

        public void Trace(Exception exception, string message, params object[] args)
        {
            Console.WriteLine(message);
        }

        public void Trace(Exception exception, IFormatProvider formatProvider, string message, params object[] args)
        {
            Console.WriteLine(message);
        }

        public void Trace(IFormatProvider formatProvider, string message, params object[] args)
        {
            Console.WriteLine(message);
        }

        public void Trace(string message)
        {
            Console.WriteLine(message);
        }

        public void Trace(string message, params object[] args)
        {
            Console.WriteLine(message);
        }

        public void Trace(string message, Exception exception)
        {
            Console.WriteLine(message);
        }

        public void Trace<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            Console.WriteLine(message);
        }

        public void Trace<TArgument>(string message, TArgument argument)
        {
            Console.WriteLine(message);
        }

        public void Trace<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1,
            TArgument2 argument2)
        {
            Console.WriteLine(message);
        }

        public void Trace<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
        {
            Console.WriteLine(message);
        }

        public void Trace<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message, TArgument1 argument1,
            TArgument2 argument2, TArgument3 argument3)
        {
            Console.WriteLine(message);
        }

        public void Trace<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2,
            TArgument3 argument3)
        {
            Console.WriteLine(message);
        }

        public void Debug<T>(T value)
        {
            DebugAction(Convert.ToString(value));
        }

        public void Debug<T>(IFormatProvider formatProvider, T value)
        {
            DebugAction(Convert.ToString(value));
        }

        public void Debug(LogMessageGenerator messageFunc)
        {
            DebugAction(messageFunc.Invoke());
        }

        public void DebugException(string message, Exception exception)
        {
            DebugAction(message);
        }

        public void Debug(Exception exception, string message)
        {
            DebugAction(message);
        }

        public void Debug(Exception exception, string message, params object[] args)
        {
            DebugAction(message);
        }

        public void Debug(Exception exception, IFormatProvider formatProvider, string message, params object[] args)
        {
            DebugAction(message);
        }

        public void Debug(IFormatProvider formatProvider, string message, params object[] args)
        {
            DebugAction(message);
        }

        public void Debug(string message)
        {
            DebugAction(message);
        }

        public void Debug(string message, params object[] args)
        {
            DebugAction(message);
        }

        public void Debug(string message, Exception exception)
        {
            DebugAction(message);
        }

        public void Debug<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            DebugAction(message);
        }

        public void Debug<TArgument>(string message, TArgument argument)
        {
            DebugAction(message);
        }

        public void Debug<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1,
            TArgument2 argument2)
        {
            DebugAction(message);
        }

        public void Debug<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
        {
            DebugAction(message);
        }

        public void Debug<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message, TArgument1 argument1,
            TArgument2 argument2, TArgument3 argument3)
        {
            DebugAction(message);
        }

        public void Debug<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2,
            TArgument3 argument3)
        {
            DebugAction(message);
        }

        public void Info<T>(T value)
        {
            Console.WriteLine(Convert.ToString(value));
        }

        public void Info<T>(IFormatProvider formatProvider, T value)
        {
            Console.WriteLine(Convert.ToString(value));
        }

        public void Info(LogMessageGenerator messageFunc)
        {
            Console.WriteLine(messageFunc.Invoke());
        }

        public void InfoException(string message, Exception exception)
        {
            Console.WriteLine(message);
        }

        public void Info(Exception exception, string message)
        {
            Console.WriteLine(message);
        }

        public void Info(Exception exception, string message, params object[] args)
        {
            Console.WriteLine(message);
        }

        public void Info(Exception exception, IFormatProvider formatProvider, string message, params object[] args)
        {
            Console.WriteLine(message);
        }

        public void Info(IFormatProvider formatProvider, string message, params object[] args)
        {
            Console.WriteLine(message);
        }

        public void Info(string message)
        {
            Console.WriteLine(message);
        }

        public void Info(string message, params object[] args)
        {
            Console.WriteLine(message);
        }

        public void Info(string message, Exception exception)
        {
            Console.WriteLine(message);
        }

        public void Info<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            Console.WriteLine(message);
        }

        public void Info<TArgument>(string message, TArgument argument)
        {
            Console.WriteLine(message);
        }

        public void Info<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1,
            TArgument2 argument2)
        {
            Console.WriteLine(message);
        }

        public void Info<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
        {
            Console.WriteLine(message);
        }

        public void Info<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message, TArgument1 argument1,
            TArgument2 argument2, TArgument3 argument3)
        {
            Console.WriteLine(message);
        }

        public void Info<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2,
            TArgument3 argument3)
        {
            Console.WriteLine(message);
        }

        public void Warn<T>(T value)
        {
            WarnAction(Convert.ToString(value));
        }

        public void Warn<T>(IFormatProvider formatProvider, T value)
        {
            WarnAction(Convert.ToString(value));
        }

        public void Warn(LogMessageGenerator messageFunc)
        {
            WarnAction(messageFunc.Invoke());
        }

        public void WarnException(string message, Exception exception)
        {
            WarnAction(message);
        }

        public void Warn(Exception exception, string message)
        {
            WarnAction(message);
        }

        public void Warn(Exception exception, string message, params object[] args)
        {
            WarnAction(message);
        }

        public void Warn(Exception exception, IFormatProvider formatProvider, string message, params object[] args)
        {
            WarnAction(message);
        }

        public void Warn(IFormatProvider formatProvider, string message, params object[] args)
        {
            WarnAction(message);
        }

        public void Warn(string message)
        {
            WarnAction(message);
        }

        public void Warn(string message, params object[] args)
        {
            WarnAction(message);
        }

        public void Warn(string message, Exception exception)
        {
            WarnAction(message);
        }

        public void Warn<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            WarnAction(message);
        }

        public void Warn<TArgument>(string message, TArgument argument)
        {
            WarnAction(message);
        }

        public void Warn<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1,
            TArgument2 argument2)
        {
            WarnAction(message);
        }

        public void Warn<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
        {
            WarnAction(message);
        }

        public void Warn<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message, TArgument1 argument1,
            TArgument2 argument2, TArgument3 argument3)
        {
            WarnAction(message);
        }

        public void Warn<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2,
            TArgument3 argument3)
        {
            WarnAction(message);
        }

        public void Error<T>(T value)
        {
            ErrorAction(Convert.ToString(value));
        }

        public void Error<T>(IFormatProvider formatProvider, T value)
        {
            ErrorAction(Convert.ToString(value));
        }

        public void Error(LogMessageGenerator messageFunc)
        {
            ErrorAction(messageFunc.Invoke());
        }

        public void ErrorException(string message, Exception exception)
        {
            ErrorAction(message);
        }

        public void Error(Exception exception, string message)
        {
            ErrorAction(message);
        }

        public void Error(Exception exception, string message, params object[] args)
        {
            ErrorAction(message);
        }

        public void Error(Exception exception, IFormatProvider formatProvider, string message, params object[] args)
        {
            ErrorAction(message);
        }

        public void Error(IFormatProvider formatProvider, string message, params object[] args)
        {
            ErrorAction(message);
        }

        public void Error(string message)
        {
            ErrorAction(message);
        }

        public void Error(string message, params object[] args)
        {
            ErrorAction(message);
        }

        public void Error(string message, Exception exception)
        {
            ErrorAction(message);
        }

        public void Error<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            ErrorAction(message);
        }

        public void Error<TArgument>(string message, TArgument argument)
        {
            ErrorAction(message);
        }

        public void Error<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1,
            TArgument2 argument2)
        {
            ErrorAction(message);
        }

        public void Error<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
        {
            ErrorAction(message);
        }

        public void Error<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message, TArgument1 argument1,
            TArgument2 argument2, TArgument3 argument3)
        {
            ErrorAction(message);
        }

        public void Error<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2,
            TArgument3 argument3)
        {
            ErrorAction(message);
        }

        public void Fatal<T>(T value)
        {
            FatalAction(Convert.ToString(value));
        }

        public void Fatal<T>(IFormatProvider formatProvider, T value)
        {
            FatalAction(Convert.ToString(value));
        }

        public void Fatal(LogMessageGenerator messageFunc)
        {
            FatalAction(messageFunc.Invoke());
        }

        public void FatalException(string message, Exception exception)
        {
            FatalAction(message);
        }

        public void Fatal(Exception exception, string message)
        {
            FatalAction(message);
        }

        public void Fatal(Exception exception, string message, params object[] args)
        {
            FatalAction(message);
        }

        public void Fatal(Exception exception, IFormatProvider formatProvider, string message, params object[] args)
        {
            FatalAction(message);
        }

        public void Fatal(IFormatProvider formatProvider, string message, params object[] args)
        {
            FatalAction(message);
        }

        public void Fatal(string message)
        {
            FatalAction(message);
        }

        public void Fatal(string message, params object[] args)
        {
            FatalAction(message);
        }

        public void Fatal(string message, Exception exception)
        {
            FatalAction(message);
        }

        public void Fatal<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            FatalAction(message);
        }

        public void Fatal<TArgument>(string message, TArgument argument)
        {
            FatalAction(message);
        }

        public void Fatal<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1,
            TArgument2 argument2)
        {
            FatalAction(message);
        }

        public void Fatal<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
        {
            FatalAction(message);
        }

        public void Fatal<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message, TArgument1 argument1,
            TArgument2 argument2, TArgument3 argument3)
        {
            FatalAction(message);
        }

        public void Fatal<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2,
            TArgument3 argument3)
        {
            FatalAction(message);
        }

        public bool IsTraceEnabled => true;
        public bool IsDebugEnabled => true;
        public bool IsInfoEnabled => true;
        public bool IsWarnEnabled => true;
        public bool IsErrorEnabled => true;
        public bool IsFatalEnabled => true;
    }
}
