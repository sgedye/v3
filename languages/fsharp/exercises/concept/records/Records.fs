module Records

type Weapon = { Name: string; Attack: int }

type Armor = { Defense: int; Durability: int }

type Character =
    { Name: string
      HitPoints: int
      Armor: Armor
      Weapon: Weapon }

let weapon name damage = { Name = name; Attack = damage }

let armor defense = { Defense = defense; Durability = 100 }

let character name hitPoints armor weapon =
    { Name = name
      HitPoints = hitPoints
      Armor = armor
      Weapon = weapon }

let swapWeapon character newWeapon = { character with Weapon = newWeapon }

let attack attacker target =
    match target with
    | { Armor = { Durability = 0 } } ->


        { target with
              HitPoints = target.HitPoints - attacker.Weapon.Attack }
