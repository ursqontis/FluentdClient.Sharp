﻿using System;
using System.Threading.Tasks;

namespace FluentdClient.Sharp
{
    /// <summary>
    /// The interface that defines methods connecting to fluentd server.
    /// </summary>
    public interface IFluentdClient : IDisposable
    {
        /// <summary>
        /// Connect to Fluentd server.
        /// </summary>
        /// <returns>The task.</returns>
        Task ConnectAsync();

        /// <summary>
        /// Send a simple message to fluentd server.
        /// </summary>
        /// <param name="tag">The tag.</param>
        /// <param name="message">The message.</param>
        /// <returns>The task.</returns>
        Task SendAsync(string tag, string message);

        /// <summary>
        /// Send a structured message to fluentd server.
        /// </summary>
        /// <typeparam name="T">The type of the message.</typeparam>
        /// <param name="tag">The tag.</param>
        /// <param name="message">The content of the message.</param>
        /// <returns>The task.</returns>
        Task SendAsync<T>(string tag, T message) where T : class;
    }
}
