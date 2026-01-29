using System.Net.Http.Json;
using BlazorDemo.Shared.Models;

namespace BlazorDemo.Client.Services;


public class ProduitServiceClient : IProduitServiceClient
{
    private readonly HttpClient _http;
    private const string BaseUrl = "api/produits";

    public ProduitServiceClient(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<Produit>> ObtenirTousAsync()
    {
        try
        {
            var result = await _http.GetFromJsonAsync<List<Produit>>(BaseUrl);
            return result ?? new List<Produit>();
        }
        catch
        {
            return new List<Produit>();
        }
    }

    Task<Produit?> IProduitServiceClient.ObtenirParIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    Task<List<Produit>> IProduitServiceClient.RechercherAsync(string terme)
    {
        throw new NotImplementedException();
    }

    Task<List<Produit>> IProduitServiceClient.ObtenirParCategorieAsync(string categorie)
    {
        throw new NotImplementedException();
    }

    Task<Produit?> IProduitServiceClient.AjouterAsync(ProduitDto dto)
    {
        throw new NotImplementedException();
    }

    Task<Produit?> IProduitServiceClient.ModifierAsync(int id, ProduitDto dto)
    {
        throw new NotImplementedException();
    }

    Task<bool> IProduitServiceClient.SupprimerAsync(int id)
    {
        throw new NotImplementedException();
    }

    Task<List<string>> IProduitServiceClient.ObtenirCategoriesAsync()
    {
        throw new NotImplementedException();
    }
}
