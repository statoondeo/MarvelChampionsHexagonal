namespace MarvelChampionsDomain;
public class Result
{
	public bool IsSuccess { get; }
	public bool IsFailure => !IsSuccess;
	public Error? Error { get; }

	protected Result(bool success, Error? error)
	{
		IsSuccess = success;
		Error = IsSuccess ? null : error;
	}

	public static Result Failed(Error error) => new(false, error);
	public static Result<T> Failed<T>(Error error) => new(default!, false, error);
	public static Result Succeed() => new(true, null);
	public static Result<T> Succeed<T>(T value) => new(value, true, null);
}
public class Result<T> : Result
{
	private readonly T? _value;
	public T Value  => IsSuccess ? _value! : throw new InvalidOperationException();
	protected internal Result(T value) : this(value, true, null) { }
	protected internal Result(T value, bool success, Error? error) : base(success, error) => _value = value;
	public static implicit operator Result<T> (T? value) => new(value!);
}