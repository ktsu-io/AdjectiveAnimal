# AdjectiveAnimal

## Overview
The `AdjectiveAnimal` application generates creative and random adjective-animal combinations with customizable casing options. This tool can be used for generating unique names, creative writing prompts, or simply for fun.

## Features
- Generate random adjective-animal pairs
- Filter results by the first letter
- Alliteration option for adjective-animal pairs
- Various case formatting options (lower, upper, title, pascal, camel, snake, kebab, macro)
- Customizable output amount
- Simple command-line interface

## Usage
1. Clone the repository:
   ```bash
   git clone https://github.com/ktsu.io/AdjectiveAnimal.git
   ```
2. Navigate to the project directory:
   ```bash
   cd AdjectiveAnimal
   ```
3. Build the project:
   ```bash
   dotnet build
   ```
4. Run the program:
   ```bash
   dotnet run -- [options]
   ```

## Options
- `--amount` or `-a`: The number of results to generate (default: 1)
- `--case` or `-c`: The case type for the output (lower, upper, title, pascal, camel, snake, kebab, macro)
- `--first-letter` or `-f`: Filter results by the first letter
- `--alliterate` or `-l`: Generate alliterative adjective-animal pairs
- `--pause` or `-p`: Pause after displaying results (default: false)

## Examples
Generate 5 title-cased names:
```bash
dotnet run -- -a 5 -c title
```

Generate 3 snake-cased, alliterative names starting with 'b':
```bash
dotnet run -- -a 3 -c snake -f b -l
```

Pause after generating 10 upper-cased names:
```bash
dotnet run -- -c upper -p
```

## License
This project is licensed under the MIT License. See the LICENSE file for more details.
