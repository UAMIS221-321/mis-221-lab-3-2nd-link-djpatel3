// start Main

string enjoymentLevel = GetEnjoymentLevel();
string stadium = GetStadiumRecommendations(enjoymentLevel);
string game = GetGameRecommendations(stadium);
DisplayStadiumDetails(stadium, game);
// end Main

// Use their enjoyment level to suggest a stadium

static string GetEnjoymentLevel(){
    System.Console.WriteLine("What is your preferred enjoyment level?");
    string enjoyment = "";
    enjoyment = System.Console.ReadLine();
    
    return enjoyment;
}


static string GetStadiumRecommendations(string enjoymentLevel){
    switch (enjoymentLevel){
        case "Boring":
            return "Neyland Stadium";
        case "Average":
            return "Jordan-Hare Stadium";
        case "Fun":
            return "Tiger Stadium";
        case "Epic":
            return "Saban Field at Bryant-Denny Stadium";
        default:
            return "";
    }
}

// Read the stadium recommendation and suggest a game
static string GetGameRecommendations(string stadium){
    switch (stadium){
        case "Neyland Stadium":
            return "vs Kent State";
        case "Jordan-Hare Stadium":
            return "vs Kentucky";
        case "Tiger Stadium":
            return "vs Alabama";
        case "Saban Field at Bryant-Denny Stadium":
            return "vs Auburn";
        default:
            return "";
    }
}
// end

// Display the stadium and game recommendation
static void DisplayStadiumDetails(string stadium, string game){
    if (stadium != ""){
        System.Console.WriteLine($"You should visit {stadium} for the game {game}!");
    }
    else{
        System.Console.WriteLine("Your preferred level is invalid!");
    }
}
// end