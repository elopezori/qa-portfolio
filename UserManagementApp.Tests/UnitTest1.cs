using Microsoft.Playwright;
using Xunit;

namespace UserManagementApp.Tests;

public class UserTests
{
    private const string BaseUrl = "http://localhost:5167/Users";

    [Fact]
    public async Task UsersPage_Should_Load()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(
            new BrowserTypeLaunchOptions { Headless = true });

        var page = await browser.NewPageAsync();
        await page.GotoAsync(BaseUrl);

        var content = await page.ContentAsync();

        Assert.Contains("Users", content);
    }

    [Fact]
    public async Task UsersPage_Should_Show_Column_Headers()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(
            new BrowserTypeLaunchOptions { Headless = true });

        var page = await browser.NewPageAsync();
        await page.GotoAsync(BaseUrl);

        var content = await page.ContentAsync();

        Assert.Contains("Id", content);
        Assert.Contains("Name", content);
        Assert.Contains("Email", content);
    }

    [Fact]
    public async Task UsersPage_Should_Show_Juan_And_Ana()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(
            new BrowserTypeLaunchOptions { Headless = true });

        var page = await browser.NewPageAsync();
        await page.GotoAsync(BaseUrl);

        var content = await page.ContentAsync();

        Assert.Contains("Juan", content);
        Assert.Contains("Ana", content);
    }

    [Fact]
    public async Task UsersPage_Should_Display_Table()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(
            new BrowserTypeLaunchOptions { Headless = true });

        var page = await browser.NewPageAsync();
        await page.GotoAsync(BaseUrl);

        var table = await page.QuerySelectorAsync("table");

        Assert.NotNull(table);
    }
}