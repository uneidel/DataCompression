﻿using System.Collections.Generic;

namespace gfoidl.DataCompression
{
    /// <summary>
    /// Defines the interface for the compression algorithms.
    /// </summary>
    public abstract class Compression : ICompression
    {
        /// <summary>
        /// Performs the compression / filtering of the input data.
        /// </summary>
        /// <param name="data">Input data</param>
        /// <returns>The compressed / filtered data.</returns>
        /// <exception cref="System.ArgumentNullException">
        /// <paramref name="data" /> is <c>null</c>.
        /// </exception>
        public IEnumerable<DataPoint> Process(IEnumerable<DataPoint> data)
        {
            if (data == null) ThrowHelper.ThrowArgumentNull(nameof(data));

            return this.ProcessCore(data);
        }
        //---------------------------------------------------------------------
        /// <summary>
        /// Implementation of the compression / filtering.
        /// </summary>
        /// <param name="data">Input data</param>
        /// <returns>The compressed / filtered data.</returns>
        protected abstract IEnumerable<DataPoint> ProcessCore(IEnumerable<DataPoint> data);
    }
}
