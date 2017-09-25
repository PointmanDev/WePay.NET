﻿namespace WePayApi.Shared.Common
{
    /// <summary>
    /// All possible sort orders
    /// </summary>
    public class SortOrders : WePayValues<SortOrders>
    {
        public enum Choices : int
        {
            Asc,
            Desc
        }

        public const string Asc = "asc";
        public const string Desc = "desc";
    }
}