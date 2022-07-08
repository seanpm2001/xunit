﻿using System;
using System.Collections.Generic;
using Xunit.Internal;

namespace Xunit.v3;

/// <summary>
/// Represents a test case that had a valid data row, but the data row was generated by a
/// data attribute with the skip property set.
/// </summary>
/// <remarks>
/// This class is only used if the discoverer is pre-enumerating theories and the data row is serializable.
/// </remarks>
public class XunitSkippedDataRowTestCase : XunitTestCase
{
	/// <summary>
	/// Called by the de-serializer; should only be called by deriving classes for de-serialization purposes
	/// </summary>
	[Obsolete("Called by the de-serializer; should only be called by deriving classes for de-serialization purposes")]
	public XunitSkippedDataRowTestCase()
	{ }

	/// <summary>
	/// Initializes a new instance of the <see cref="XunitSkippedDataRowTestCase"/> class.
	/// </summary>
	/// <param name="defaultMethodDisplay">Default method display to use (when not customized).</param>
	/// <param name="defaultMethodDisplayOptions">Default method display options to use (when not customized).</param>
	/// <param name="testMethod">The test method this test case belongs to.</param>
	/// <param name="testMethodArguments">The arguments for the test method.</param>
	/// <param name="skipReason">The reason that this test case will be skipped.</param>
	/// <param name="traits">The optional traits list; if not provided, will be read from trait attributes.</param>
	/// <param name="uniqueID">The optional unique ID for the test case; if not provided, will be calculated.</param>
	/// <param name="displayName">The optional display name for the test</param>
	public XunitSkippedDataRowTestCase(
		TestMethodDisplay defaultMethodDisplay,
		TestMethodDisplayOptions defaultMethodDisplayOptions,
		_ITestMethod testMethod,
		object?[] testMethodArguments,
		string skipReason,
		Dictionary<string, List<string>>? traits = null,
		string? uniqueID = null,
		string? displayName = null) :
			base(
				defaultMethodDisplay,
				defaultMethodDisplayOptions,
				testMethod,
				testMethodArguments,
				Guard.ArgumentNotNull(skipReason),
				traits,
				timeout: null,
				uniqueID,
				displayName
			)
	{ }
}
