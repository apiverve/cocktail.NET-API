Cocktail Recipe API
============

Cocktail is a simple tool for getting cocktail recipes. It returns the ingredients, instructions, and more of the cocktail.

![Build Status](https://img.shields.io/badge/build-passing-green)
![Code Climate](https://img.shields.io/badge/maintainability-B-purple)
![Prod Ready](https://img.shields.io/badge/production-ready-blue)

This is a .NET Wrapper for the [Cocktail Recipe API](https://apiverve.com/marketplace/api/cocktail)

---

## Installation

Using the .NET CLI:
```
dotnet add package APIVerve.API.CocktailRecipe
```

Using the Package Manager:
```
nuget install APIVerve.API.CocktailRecipe
```

Using the Package Manager Console:
```
Install-Package APIVerve.API.CocktailRecipe
```

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on Manage NuGet Packages...
4. Click on the Browse tab and search for "APIVerve.API.CocktailRecipe".
5. Click on the APIVerve.API.CocktailRecipe package, select the appropriate version in the right-tab and click Install.


---

## Configuration

Before using the cocktail API client, you have to setup your account and obtain your API Key.  
You can get it by signing up at [https://apiverve.com](https://apiverve.com)

---

## Usage

The Cocktail Recipe API documentation is found here: [https://docs.apiverve.com/api/cocktail](https://docs.apiverve.com/api/cocktail).  
You can find parameters, example responses, and status codes documented here.

### Setup

###### Authentication
Cocktail Recipe API uses API Key-based authentication. When you create an instance of the API client, you can pass your API Key as a parameter.

```
// Create an instance of the API client
var apiClient = new CocktailRecipeAPIClient("[YOUR_API_KEY]", true);
```

---


### Perform Request
Using the API client, you can perform requests to the API.

###### Define Query

```
var queryOptions = new CocktailRecipeQueryOptions {
  name = "martini"
};
```

###### Simple Request

```
var response = apiClient.Execute(queryOptions);
if(response.error != null) {
	Console.WriteLine(response.error);
} else {
    var jsonResponse = JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented);
    Console.WriteLine(jsonResponse);
}
```

###### Example Response

```
{
  "status": "ok",
  "error": null,
  "data": {
    "count": 5,
    "filteredOn": "name",
    "cocktails": [
      {
        "name": "Espresso Martini",
        "glass": "martini",
        "category": "After Dinner Cocktail",
        "ingredients": [
          {
            "unit": "cl",
            "amount": 5,
            "ingredient": "Vodka"
          },
          {
            "unit": "cl",
            "amount": 1,
            "ingredient": "Coffee liqueur",
            "label": "Kahlúa"
          },
          {
            "special": "Sugar syrup (according to individual preference of sweetness)"
          },
          {
            "special": "1 short strong Espresso"
          }
        ],
        "preparation": "Shake and strain into a chilled cocktail glass."
      },
      {
        "name": "Lemon Drop Martini",
        "glass": "martini",
        "category": "All Day Cocktail",
        "ingredients": [
          {
            "unit": "cl",
            "amount": 2.5,
            "ingredient": "Vodka",
            "label": "Citron Vodka"
          },
          {
            "unit": "cl",
            "amount": 2,
            "ingredient": "Triple Sec"
          },
          {
            "unit": "cl",
            "amount": 1.5,
            "ingredient": "Lemon juice"
          }
        ],
        "garnish": "Lemon slice",
        "preparation": "Shake and strain into a chilled cocktail glass rimmed with sugar."
      },
      {
        "name": "French Martini",
        "glass": "martini",
        "category": "Before Dinner Cocktail",
        "ingredients": [
          {
            "unit": "cl",
            "amount": 4.5,
            "ingredient": "Vodka"
          },
          {
            "unit": "cl",
            "amount": 1.5,
            "ingredient": "Raspberry liqueur"
          },
          {
            "unit": "cl",
            "amount": 1.5,
            "ingredient": "Pineapple juice"
          }
        ],
        "preparation": "Stir in mixing glass with ice cubes. Strain into chilled cocktail glass. Squeeze oil from lemon peel onto the drink."
      },
      {
        "name": "Dirty Martini",
        "glass": "martini",
        "category": "Before Dinner Cocktail",
        "ingredients": [
          {
            "unit": "cl",
            "amount": 6,
            "ingredient": "Vodka"
          },
          {
            "unit": "cl",
            "amount": 1,
            "ingredient": "Vermouth",
            "label": "Dry vermouth"
          },
          {
            "unit": "cl",
            "amount": 1,
            "ingredient": "Olive juice"
          }
        ],
        "garnish": "Green olive",
        "preparation": "Stir in mixing glass with ice cubes. Strain into chilled martini glass."
      },
      {
        "name": "Dry Martini",
        "glass": "martini",
        "category": "Before Dinner Cocktail",
        "ingredients": [
          {
            "unit": "cl",
            "amount": 6,
            "ingredient": "Gin"
          },
          {
            "unit": "cl",
            "amount": 1,
            "ingredient": "Vermouth",
            "label": "Dry vermouth"
          }
        ],
        "preparation": "Stir in mixing glass with ice cubes. Strain into chilled martini glass. Squeeze oil from lemon peel onto the drink, or garnish with olive."
      }
    ]
  },
  "code": 200
}
```

---

## Customer Support

Need any assistance? [Get in touch with Customer Support](https://apiverve.com/contact).

---

## Updates
Stay up to date by following [@apiverveHQ](https://twitter.com/apiverveHQ) on Twitter.

---

## Legal

All usage of the APIVerve website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms) and all legal documents and agreements.

---

## License
Licensed under the The MIT License (MIT)

Copyright (&copy;) 2024 APIVerve, and Evlar LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.