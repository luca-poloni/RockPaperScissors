using Application.Models;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Text;
using System.Text.Json;

namespace Application.IntegrationTests.Controllers
{
    public sealed class GameControllerTest : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _httpClient;

        public GameControllerTest(WebApplicationFactory<Program> factory)
        {
            _httpClient = factory.CreateClient();
        }

        [Fact]
        public async Task PlayPost_WithValidPlayers_ShouldBeStatusCodeOK()
        {
            #region Arrange
            var playerOne = new PlayerModel("Luca", "Rock");
            var playerTwo = new PlayerModel("Caio", "Paper");
            var players = new PlayersModel(playerOne, playerTwo);
            var json = JsonSerializer.Serialize(players);
            var request = CreateRequest(json);
            #endregion

            #region Act
            var response = await _httpClient.SendAsync(request);
            #endregion

            #region Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK); 
            #endregion
        }

        [Fact]
        public async Task PlayPost_WithInvalidPlayersPropertys_ShouldBeStatusCodeBadRequest()
        {
            #region Arrange
            var invalidPlayerOne = new PlayerModel(string.Empty, string.Empty);
            var invalidPlayerTwo = new PlayerModel(string.Empty, string.Empty);
            var players = new PlayersModel(invalidPlayerOne, invalidPlayerTwo);
            var json = JsonSerializer.Serialize(players);
            var request = CreateRequest(json);
            #endregion

            #region Act
            var response = await _httpClient.SendAsync(request);
            #endregion

            #region Assert
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
            #endregion
        }

        [Fact]
        public async Task PlayPost_WithInvalidPlayers_ShouldBeStatusCodeBadRequest()
        {
            #region Arrange
            var request = CreateRequest(string.Empty);
            #endregion

            #region Act
            var response = await _httpClient.SendAsync(request);
            #endregion

            #region Assert
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
            #endregion
        }

        private static HttpRequestMessage CreateRequest(string json)
        {
            return new HttpRequestMessage(HttpMethod.Post, "/api/v1/game/play")
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
        }
    }
}
