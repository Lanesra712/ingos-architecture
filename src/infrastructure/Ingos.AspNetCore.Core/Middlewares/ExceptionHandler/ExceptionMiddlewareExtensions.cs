﻿//-----------------------------------------------------------------------
// <copyright file= "ExceptionMiddlewareExtensions.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2020/7/6 20:23:51
// Modified by:
// Description: Exception middleware extension method
//-----------------------------------------------------------------------

using Microsoft.AspNetCore.Builder;

namespace Ingos.AspNetCore.Core.Middlewares.ExceptionHandler
{
    /// <summary>
    ///     Exception middleware extension method
    /// </summary>
    public static class ExceptionMiddlewareExtensions
    {
        /// <summary>
        ///     Use Ingos's exception middleware
        /// </summary>
        /// <param name="builder">request pipeline.<see cref="IApplicationBuilder" /></param>
        /// <returns></returns>
        public static IApplicationBuilder UseIngosExceptionHandler(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionMiddleware>();
        }
    }
}