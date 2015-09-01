﻿using Xunit;

namespace Project.MyAnimeList.Test
{
	[Collection("Credential collection")]
	public class AccountMethodsTest
	{
		public CredentialContextFixture CredentialContextFixture { get; set; }

		public AccountMethodsTest(CredentialContextFixture credentialContextFixture)
		{
			CredentialContextFixture = credentialContextFixture;
		}

		[Fact]
		public void TestCredentialContextNotEmpty()
		{
			var sut = CredentialContextFixture.CredentialContext;

			Assert.False(string.IsNullOrEmpty(sut.UserName));
			Assert.False(string.IsNullOrEmpty(sut.Password));
		}
	}
}
