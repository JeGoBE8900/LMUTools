﻿using Newtonsoft.Json;
using System.Text;

namespace LMUTools.Classes.LMURESTAPI
{

    public sealed class LMUAPIRestService
    {
        private const string BaseUrl = "http://localhost:6397";
        private readonly HttpClient _client;
        private Boolean _apiReady;

        public LMUAPIRestService(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<LMUReplay>> GetLMUReplaysAsync()
        {
            try
            {
                var httpResponse = await _client.GetAsync(BaseUrl + "/rest/watch/replays");

                if (!httpResponse.IsSuccessStatusCode)
                {
                    throw new Exception("Cannot retrieve replays");
                }

                var content = await httpResponse.Content.ReadAsStringAsync();
                var replays = JsonConvert.DeserializeObject<List<LMUReplay>>(content);

                return replays;

            }catch (Exception ex)
            {
                return new List<LMUReplay>();

            }
        }

        public async Task<List<LMUStanding>> GetLMUStandingAsync()
        {
            try
            {
                var httpResponse = await _client.GetAsync(BaseUrl + "/rest/watch/standings");

                if (!httpResponse.IsSuccessStatusCode)
                {
                    throw new Exception("Cannot retrieve replays");
                }

                var content = await httpResponse.Content.ReadAsStringAsync();
                var standings = JsonConvert.DeserializeObject<List<LMUStanding>>(content);

                return standings;

            }
            catch (Exception ex)
            {
                return new List<LMUStanding>();

            }
        }


        public async Task<LMUReplay> GetLMUReplayInfoAsync()
        {
            try
            {

                var httpResponse = await _client.GetAsync(BaseUrl + "/rest/watch/replayInfo");

                if (!httpResponse.IsSuccessStatusCode)
                {
                    return null;
                }

                var content = await httpResponse.Content.ReadAsStringAsync();
                var replayInfo = JsonConvert.DeserializeObject<LMUReplay>(content);

                return replayInfo;

            }catch (Exception ex)
            {
                return null;
            }

        }

        public async Task<Boolean> PutLMUReplayCameraSlotIdAsync(int slotId)
        {
            try
            {

                var httpResponse = await _client.PutAsync(BaseUrl + "/rest/replay/camera/" + slotId,null);

                if (!httpResponse.IsSuccessStatusCode)
                {
                    return false;
                }

                //var content = await httpResponse.Content.ReadAsStringAsync();
                //var replayInfo = JsonConvert.DeserializeObject<LMUReplay>(content);

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public async Task<Boolean> PutLMUReplayTimeAsync(Int32 time)
        {
            try
            {
                StringContent queryString = new StringContent(time.ToString(),Encoding.UTF8, "application/json");

                var httpResponse = await _client.PutAsync(BaseUrl + "/rest/replay/replaytime", queryString);

                if (!httpResponse.IsSuccessStatusCode)
                {
                    return false;
                }

                //var content = await httpResponse.Content.ReadAsStringAsync();
                //var replayInfo = JsonConvert.DeserializeObject<LMUReplay>(content);

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public async Task<Boolean> PostLMUReplayPlaybackCommand(Int32 Speed)
        {
            try
            {

                if(Speed >= 2 && Speed <= 10)
                {
                    StringContent queryString = new StringContent(Speed.ToString(), Encoding.UTF8, "application/json");

                    var httpResponse = await _client.PostAsync(BaseUrl + "/rest/replay/playbackcommand", queryString);

                    if (!httpResponse.IsSuccessStatusCode)
                    {
                        return false;
                    }

                    //var content = await httpResponse.Content.ReadAsStringAsync();
                    //var replayInfo = JsonConvert.DeserializeObject<LMUReplay>(content);

                    return true;

                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public async Task<String> GetLMUReplayPlayID(int ID)
        {
            try
            {
                var httpResponse = await _client.GetAsync(BaseUrl + "/rest/watch/play/" + ID);

                if (!httpResponse.IsSuccessStatusCode)
                {
                    throw new Exception("Cannot start replay");
                }

                var content = await httpResponse.Content.ReadAsStringAsync();
                return content;

            }catch(Exception ex)
            {
                return "Error loading replay file";

            }

        }

        public async Task<String> GetLMUSessionInfo()
        {
            try
            {
                var httpResponse = await _client.GetAsync(BaseUrl + "/rest/watch/sessionInfo/");

                if (!httpResponse.IsSuccessStatusCode)
                {
                    throw new Exception("Cannot get session info");
                }

                var content = await httpResponse.Content.ReadAsStringAsync();

                if(content.IndexOf("\"session\":\"INVALID\"") > -1)
                {
                    content = "";
                }


                return content;

            }
            catch (Exception ex)
            {
                return "Cannot get session info";

            }

        }

        public async Task<Boolean> GetLMUReplayIsActive()
        {
            try
            {
                var httpResponse = await _client.GetAsync(BaseUrl + "/rest/watch/replay/isActive");

                if (!httpResponse.IsSuccessStatusCode)
                {
                    throw new Exception("Cannot get session info");
                }

                var content = await httpResponse.Content.ReadAsStringAsync();

                if (content.ToLower().Trim() == "true")
                {
                    return true;
                }


                return false;

            }
            catch (Exception ex)
            {
                return false;

            }

        }

        public async Task<int> GetLMUReplayCarFocus()
        {
            try
            {
                var httpResponse = await _client.GetAsync(BaseUrl + "/rest/watch/focus");

                if (!httpResponse.IsSuccessStatusCode)
                {
                    throw new Exception("Cannot get session info");
                }

                var content = await httpResponse.Content.ReadAsStringAsync();

                return Convert.ToInt32(content);

            }
            catch (Exception ex)
            {
                return 0;

            }

        }

        public async Task<Boolean> GetLMUApiStatusAsync()
        {
            try
            {
                //http://localhost:6397/navigation/state
                //var httpResponse = await _client.GetAsync(BaseUrl + "/watch/replays");  zorgt voor time-outs in game
                var httpResponse = await _client.GetAsync(BaseUrl + "/navigation/state");
                _apiReady = httpResponse.IsSuccessStatusCode;

            }catch (Exception ex)
            {
                _apiReady = false;
            }

            return _apiReady;
        }

    }

}