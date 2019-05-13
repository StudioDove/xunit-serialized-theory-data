namespace XUnit.Utilities
{
    /// <summary>
    /// Used to create <see cref="Utilities.TheoryDatum{T}" /> objects.
    /// </summary>
    public static class TheoryDatum
    {
        /// <summary>
        /// Creates a <see cref="TheoryDatum{T}"/> that wraps the specified data to serialize.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataToSerialize">The data to serialize.</param>
        /// <returns>TheoryDatum&lt;T&gt;.</returns>
        public static TheoryDatum<T> Create<T>(T dataToSerialize) => new TheoryDatum<T>(dataToSerialize);

        /// <summary>
        /// Returns the data wrapped in a <see cref="TheoryDatum{T}"/>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataToSerialize">The data to serialize.</param>
        /// <returns>TheoryDatum&lt;T&gt; that wraps the data.</returns>
        public static TheoryDatum<T> ToTheoryDatum<T>(this T dataToSerialize) => Create(dataToSerialize);
    }
}
