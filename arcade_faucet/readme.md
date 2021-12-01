# Faucet Game
This is a gamified faucet designed for OPGames during [Gitcoin Round 10](https://gitcoin.co/issue/alto-io/gr-10/3/100025936).

### Testnet Demo
![Gameplay](https://user-images.githubusercontent.com/1028926/124869560-3d267e80-df76-11eb-8797-feaba3af4d30.gif)

**Playable**: http://kraniumtivity.com/Extra/OPFaucet

**Full Gameplay**: [Pending]

**Faucet Contract**: [0xEaf4c92BC9Ef176cD29E5d888915A5e12662ea90](https://testnet.bscscan.com/address/0xEaf4c92BC9Ef176cD29E5d888915A5e12662ea90) ([source](Brownie/contracts/Faucet.sol))

## Objective
Players must try catching coins falling from the clouds before time runs out, all while running across the edge of a cliff without falling off. Successful players will claim token amounts based on their performance. Those unfortunate to fall off the cliff will forfeit any collected coins. The coins represent a configurable amount of tokens granted to the players wallet upon winning.

| Win | Lose |
|--|--|
| ![image](https://user-images.githubusercontent.com/1028926/124542344-17fc0980-ddd8-11eb-8c61-4fae1678a824.png) | ![image](https://user-images.githubusercontent.com/1028926/124542488-509be300-ddd8-11eb-9526-f7013bfa7b88.png)

## Tech Specs
This game was built using the GameLegOS entry: [Game Faucet](https://github.com/kilogold/gr10-OP_GameLegOS)  
This deployment uses Binance Smart Chain testnet, and awards players testnet BNB. 
