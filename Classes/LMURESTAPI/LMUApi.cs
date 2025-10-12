using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Text.Json.Nodes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

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
                    return null;
                    //throw new Exception("Cannot retrieve replays");
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


        /* Not supported by LMU 0.9
         * 
         * public async Task<LMUReplay> GetLMUReplayInfoAsync()
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

        }*/

        public async Task<Boolean> PutLMUReplayCameraSlotIdAsync(int slotId)
        {
            try
            {
                StringContent queryString = new StringContent(slotId.ToString(), Encoding.UTF8, "application/json");

                //var httpResponse = await _client.PutAsync(BaseUrl + "/rest/replay/camera/" + slotId,null);
                var httpResponse = await _client.PutAsync(BaseUrl + "/rest/watch/focus/" + slotId,queryString);

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

                var httpResponse = await _client.PutAsync(BaseUrl + "/rest/watch/replaytime/" + time.ToString(), queryString);

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


        public async Task<Boolean> PostLMUReplayPlaybackCommand(string Speed)
        {
            StringContent queryString = new StringContent(("{}").ToString(), Encoding.UTF8, "application/json");
            var httpResponse = await _client.PutAsync(BaseUrl + "/rest/watch/replayCommand/" + Speed, queryString);

            if (!httpResponse.IsSuccessStatusCode)
            {
                return false;
            }

            return true;

        }
        /*  OLD LMU Code until v0.5
         * 
         * public async Task<Boolean> PostLMUReplayPlaybackCommand(Int32 Speed)
        {
            try
            {

                if(Speed >= 2 && Speed <= 10)
                {
                    StringContent queryString = new StringContent(Speed.ToString(), Encoding.UTF8, "application/json");

                    var httpResponse = await _client.PostAsync(BaseUrl + "/rest/replay/playbackcommand/", queryString);

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

        }*/

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

        public async Task<JObject> GetLMUSessionInfo()
        {
            JObject jError = JObject.Parse("{\"error\" : \"no session info\" }");
            JObject jContent = null;

            try
            {
                var httpResponse = await _client.GetAsync(BaseUrl + "/rest/watch/sessionInfo");

                if (!httpResponse.IsSuccessStatusCode)
                {
                    throw new Exception("Cannot get session info");
                }

                var strContent = await httpResponse.Content.ReadAsStringAsync();

                if(strContent.IndexOf("\"session\":\"INVALID\"") > -1)
                {
                    return jError;
                }


                try {
                    jContent = JObject.Parse(strContent);
                }
                catch (Exception ex)
                {
                    return jError;
                }


                return jContent;

            }
            catch (Exception ex)
            {
                return jError;
            };

        }

        public async Task<Boolean> GetLMUReplayIsActive()
        {
            try
            {
                var httpResponse = await _client.GetAsync(BaseUrl + "/rest/replay/isActive");

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


        public async Task<Boolean> PostLMUReplayCameraControllerSetCamera(Int32 CameraOption)
        {
            try
            {
                var jsonPost = "";

                if (CameraOption == 0) { jsonPost = "{\"cameraGroup\":\"Driving\",\"direction\":0} "; }
                else if (CameraOption == 1) { jsonPost = "{\"cameraGroup\":\"Driving\",\"direction\":1} "; }
                else if (CameraOption == 2) { jsonPost = "{\"cameraGroup\":\"Trackside\",\"direction\":0}  "; }
                else if (CameraOption == 3) { jsonPost = "{\"cameraGroup\":\"Trackside\",\"direction\":1}  "; }
                else if (CameraOption == 4) { jsonPost = "{\"cameraGroup\":\"Onboard\",\"direction\":0}  "; }
                else if (CameraOption == 5) { jsonPost = "{\"cameraGroup\":\"Onboard\",\"direction\":1}  "; }
                else { return false; }


                StringContent queryString = new StringContent(jsonPost, Encoding.UTF8, "application/json");
                var httpResponse = await _client.PostAsync(BaseUrl + "/rest/replay/CameraController/setCamera", queryString);

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

    }

}