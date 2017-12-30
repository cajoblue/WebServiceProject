package pt.ipleiria.celsoteixeira.mobileapplication;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.Toast;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.JsonArrayRequest;
import com.android.volley.toolbox.Volley;
import com.google.gson.Gson;

import org.json.JSONArray;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Map;

import pt.ipleiria.celsoteixeira.mobileapplication.model.Donor;
import pt.ipleiria.celsoteixeira.mobileapplication.model.Singleton;

public class Activity_searchByIMC extends AppCompatActivity {
    private ArrayAdapter<Donor> adapter;
    private ListView listView_search;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_search_by_imc);


        this.listView_search = findViewById(R.id.listView_searchByIMC);
    }

    public void button_searchByIMC(View view) {
        RequestQueue queue = Volley.newRequestQueue(this);

        EditText editText_minAge = findViewById(R.id.minIMC);
        double minIMC = Double.parseDouble(editText_minAge.getText().toString());
        EditText editText_maxAge = findViewById(R.id.maxIMC);
        double maxIMC = Double.parseDouble(editText_maxAge.getText().toString());

        final ArrayList<Donor> searchedContacts = new ArrayList<Donor>();

        //Mostrar os resultados na listView


        //url que permitre solicita/aceder a operação getContacts
        final String url = "http://contactswebservice.apphb.com/Service.svc/rest/searchByIMC?minIMC=" + minIMC + "&maxIMC=" + maxIMC;
/*
* fazemos quando a resposta sera um array. No caso será um array de contactos, se fosse um objtivo usariamos uma JsonObjetRequest
* */

        JsonArrayRequest request = new JsonArrayRequest(
                //null-> no caso não envio nada para o servidor logo é null, do contrario teria de apresentar os dados a enviar
                Request.Method.GET,
                url,
                null,
                new Response.Listener<JSONArray>() {

                    //se correr tudo bem da uma resposta
                    @Override
                    public void onResponse(JSONArray response) {
 /*string json com os contatos existentes na agenda*/
                        Log.d("Response", response.toString());
                        Gson gson = new Gson();
         /*recebe a string json e a classe para onde sera descerializavda*/
                        Donor[] contacts = gson.fromJson(
                                response.toString(), Donor[].class);
         /*ja tenho a lista de contactos e vou percorre-la*/
                        for (Donor donor : contacts) {
                            searchedContacts.add(donor);
                        }
         /*para refrescar a agenda*/
                        //   adapter.notifyDataSetChanged();
                    }
                },
                new Response.ErrorListener() {
                    //se correr mal dá um erro
                    @Override
                    public void onErrorResponse(VolleyError error) {
                        Log.e("Response", error.getMessage());
                        Toast.makeText(Activity_searchByIMC.this,
                                "Error retrieving contacts from webservice.",
                                Toast.LENGTH_SHORT).show();
                    }
                }
        ) {
            @Override
            public Map<String, String> getHeaders() {
                HashMap<String, String> headers = new HashMap<>();
                headers.put("Content-Type", "application/json");
                return headers;
            }
        };
        queue.add(request);

        ArrayAdapter<Donor> adapter = new ArrayAdapter<Donor>(this, android.R.layout.simple_list_item_1, searchedContacts);
        listView_search.setAdapter(adapter);

        //mostar uma toast caso não tenhaam sido encontrados contactos
        if (searchedContacts.isEmpty()) {
            Toast.makeText(this, "No Contacts found...", Toast.LENGTH_LONG).show();
        }


    }

}
