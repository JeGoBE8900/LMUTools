using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMUTools.Classes.LMURESTAPI
{
    public class LMUStanding
    {

        public int slotID { get; set; }
        public string driverName { get; set; }
        public string vehicleName { get; set; }
        public string carClass { get; set; }
        public string carNumber { get; set; }
        public Boolean hasFocus { get; set; }
        public int steamId { get; set; }

        public int position { get; set; }

        public override string ToString()
        {
            return this.slotID + " - " + driverName;
        }

        public string plainJsonText { get; set; }

    }
}


/*
 
    {
    "slotID": 0,
    "driverName": "Jeroen Goudeseune",
    "vehicleName": "50 Ferrari AF Corse:EC",
    "lapsCompleted": 0,
    "sector": "SECTOR1",
    "finishStatus": "FSTAT_NONE",
    "lapDistance": 1290.2742919921875,
    "pathLateral": 16.464847564697266,
    "trackEdge": 30,
    "bestSectorTime1": -1,
    "bestSectorTime2": -1,
    "bestLapTime": -1,
    "lastSectorTime1": 0,
    "lastSectorTime2": 0,
    "lastLapTime": 0,
    "currentSectorTime1": -1,
    "currentSectorTime2": -1,
    "pitstops": 0,
    "penalties": 0,
    "player": false,
    "inControl": 1,
    "pitting": true,
    "position": 1,
    "carClass": "Hyper",
    "timeBehindNext": 0,
    "lapsBehindNext": 0,
    "timeBehindLeader": 0,
    "lapsBehindLeader": 0,
    "lapStartET": 0,
    "carPosition": {
      "type": -1,
      "y": -8.872328,
      "z": 39.406334,
      "x": -127.39152
    },
    "carVelocity": {
      "x": 0,
      "y": 0,
      "z": 0,
      "velocity": 0
    },
    "carAcceleration": {
      "x": 0,
      "y": 0,
      "z": 0,
      "velocity": 0
    },
    "headlights": false,
    "pitState": "EXITING",
    "serverScored": true,
    "gamePhase": "GREEN",
    "qualification": 11,
    "timeIntoLap": 1.358938455581665,
    "estimatedLapTime": 100.7723388671875,
    "pitGroup": "Group8",
    "flag": "GREEN",
    "underYellow": false,
    "countLapFlag": "COUNT_LAP_ONLY",
    "inGarageStall": true,
    "upgradePack": "00000000000000000000000000000000",
    "pitLapDistance": 4613.3115,
    "bestLapSectorTime1": -1,
    "bestLapSectorTime2": -1,
    "steamID": 0,
    "vehicleFilename": "50_AFCORSE7F072233",
    "carId": "2d5d64f37831595cb7f44b1052b05a2afd051891",
    "carNumber": "50",
    "fullTeamName": "Ferrari",
    "hasFocus": true,
    "fuelFraction": 0.31764707,
    "attackMode": {
      "totalCount": 0,
      "remainingCount": 0,
      "timeRemaining": 0
    },
    "focus": true,
    "drsActive": false
  },


*/