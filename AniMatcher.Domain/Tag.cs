﻿namespace AniMatcher.Domain;

/// <summary>
/// Тег.
/// </summary>
public class Tag
{
	public Tag(string tagName)
	{
		ArgumentException.ThrowIfNullOrWhiteSpace(tagName);
		
		TagName = tagName;
		TagId = Guid.NewGuid();
	}

	/// <summary>
	/// Идентификатор.
	/// </summary>
	public Guid TagId { get; set; }
	
	/// <summary>
	/// Название.
	/// </summary>
	public string TagName { get; set; }
}