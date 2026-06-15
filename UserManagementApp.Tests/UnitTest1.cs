using Microsoft.Playwright;
using Xunit;

namespace UserManagementApp.Tests;

public class UserTests
{
    [Fact]
    public async Task UsersPage_Should_Load()
    {
        using var playwright = await Playwright.CreateAsync();

        await using var browser = await playwright.Chromium.LaunchAsync(
            new BrowserTypeLaunchOptions
            {
                Headless = true
            });

        var page = await browser.NewPageAsync();

        await page.GotoAsync("http://localhost:5167/Users");

        var content = await page.ContentAsync();

        Assert.Contains("Juan", content);
        Assert.Contains("Ana", content);
    }
}