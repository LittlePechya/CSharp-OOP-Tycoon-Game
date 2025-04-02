# Console Tycoon  

## About the Project  

Console Tycoon is a simple tycoon-style game built in C# for practicing Object-Oriented Programming (OOP) concepts. The project demonstrates the use of classes, inheritance, access modifiers, and abstract classes in a small interactive game.  

## Gameplay  

The game presents the player with a text-based menu in the console, allowing them to:  

- View their current balance  
- Mine resources  
- Sell collected resources  
- Buy tools  
- Equip tools  

### Mining Resources  

- If the player does not have an equipped tool, they will see a message:  
  `"You need to equip a tool first!"`  
- If the equipped tool has enough power to mine the selected resource, the resource is added to the inventory.  
- If the tool's power is insufficient, the player will see:  
  `"The tool is too weak to mine this resource!"`  

### Selling Resources  

- The player can sell all collected resources at once.  
- The total value of the resources is added to the player's balance.  

### Buying Tools  

- Tools can be purchased if the player has enough money.  
- If a tool is already owned, the player will be notified.  

### Equipping Tools  

- The player can equip any tool they have purchased to improve mining efficiency.  

## Technologies Used  

- C#  
- .NET Console Application  

## How to Play  

1. Clone the repository  
2. Open the project in Visual Studio or any C# IDE  
3. Run the application  
