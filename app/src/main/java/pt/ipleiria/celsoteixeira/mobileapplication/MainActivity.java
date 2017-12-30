package pt.ipleiria.celsoteixeira.mobileapplication;

import android.content.Context;
import android.content.Intent;
import android.support.v4.widget.DrawerLayout;
import android.support.v7.app.ActionBarDrawerToggle;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.Toast;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.JsonArrayRequest;
import com.android.volley.toolbox.Volley;
import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.JsonDeserializationContext;
import com.google.gson.JsonDeserializer;
import com.google.gson.JsonElement;
import com.google.gson.JsonParseException;

import org.json.JSONArray;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.Date;
import java.util.HashMap;
import java.util.Map;

import pt.ipleiria.celsoteixeira.mobileapplication.model.BloodCrowd;
import pt.ipleiria.celsoteixeira.mobileapplication.model.Donor;
import pt.ipleiria.celsoteixeira.mobileapplication.model.Singleton;

public class MainActivity extends AppCompatActivity {

    private ListView listView;
    public static final String EXTRA_AGENDA = "pt.ipleiria.celsoteixeira.mobileapplication.BloodCrowd";
    private static final int REQUEST_CODE_ADD = 1;
    private ArrayAdapter<Donor> adapter;
    private DrawerLayout mDrawerLayout;
    private ActionBarDrawerToggle aToggle;
    private BloodCrowd bloodCrowd_management = new BloodCrowd();



    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //colocar aqui o codigo necessário para restaurar a agenda do disco
        try {
            FileInputStream fileInputStream = openFileInput("bloodCrowd.bin");
            ObjectInputStream objectInputStream = new
                    ObjectInputStream(fileInputStream);
            Singleton.getInstance().setBloodCrowd(
                    (BloodCrowd) objectInputStream.readObject());
            objectInputStream.close();
            fileInputStream.close();
        } catch (FileNotFoundException e) {
            e.printStackTrace();
            Toast.makeText(MainActivity.this,
                    "Could not read BloodCrowd from internal storage (no BloodCrowd yet?).",
                    Toast.LENGTH_LONG).show();
        } catch (IOException | ClassNotFoundException e) {
            e.printStackTrace();
            Toast.makeText(MainActivity.this,
                    "Error reading BloodCrowd from internal storage.",
                    Toast.LENGTH_LONG).show();
        }


        //ArrayAdapter -> faz a ponte entre o array e a list view
        //segundo parametro o leyout para os itens individuais
        //android.R ->  faz parte da biblioteca
        //agenda.getContacts() -> fonte de dados da agenda
        adapter = new ArrayAdapter<>(this,android.R.layout.simple_list_item_1, Singleton.getInstance().getBloodCrowd().getDonors());//comunica com a liste view pegar os dados e mandar para o array

        listView = findViewById(R.id.listView_donors);//listeview,  contacta a minha listview, sff
        listView.setAdapter(adapter);// liste view recebe os meus dados, sff
    }

    public void OnClick_searchByNAme(MenuItem item) {
        //  Toast.makeText(this, "Add clicked", Toast.LENGTH_SHORT).show();//toact(vai mostrar a ação associada a um button no front-end) Toast.LENGTH_SHORT).show()(o tempo de duração que o texto sugestão é apresentado)
        Intent i = new Intent(this, activity_searchByName.class);
        startActivity(i);//recebe dois parametro de entrada, o itente(i) e o request_code(codigo que identifica esta chamada)(o request serve para destinguir atividades---deve ser diferente e é a escolha do programador...deve ser um inteiro)
    }

    public void OnClick_searchByAge(MenuItem item) {
        Intent i = new Intent(this, Activity_searchByAge.class);
        startActivity(i);
    }
    public void OnClick_searchByIMC(MenuItem item) {
        Intent i = new Intent(this, Activity_searchByIMC.class);
        startActivity(i);
    }

    public void OnClick_searchByBlood(MenuItem item) {
        Intent i = new Intent(this, Activity_search_ByBloodType.class);
        startActivity(i);
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        int id = item.getItemId();
        switch (id) {
            case (R.id.ic_action_search):
                Intent i = new Intent(this, activity_searchByName.class);

                i.putExtra(EXTRA_AGENDA,Singleton.getInstance().toString());
                startActivity(i);
                break;
            case (R.id.drawerlayout):

                mDrawerLayout = (DrawerLayout) findViewById(R.id.drawerlayout);
                aToggle = new ActionBarDrawerToggle(this, mDrawerLayout, R.string.open, R.string.close);
                mDrawerLayout.addDrawerListener(aToggle);
                aToggle.syncState();
                getSupportActionBar().setDisplayHomeAsUpEnabled(true);
                
                if (aToggle.onOptionsItemSelected(item)){
                    return true;
                }

        }
        return super.onOptionsItemSelected(item);
    }






    @Override
    protected void onPause() {//onde coloco o codigo necessário para gravar a agenda para disco
        super.onPause();
//o try-catch aqui é obrigatório
        try {
            FileOutputStream fileOutputStream =
                    openFileOutput("bloodCrowd.bin", Context.MODE_PRIVATE);
            ObjectOutputStream objectOutputStream = new ObjectOutputStream(fileOutputStream);

            //escrever os dados dad agenda no ficheiro objectOutputStream
            objectOutputStream.writeObject(Singleton.getInstance().getBloodCrowd());

            objectOutputStream.close();
            fileOutputStream.close();

        } catch (IOException e) {//IO -> exceção de imput e output
            //server para imprimir a informação de erro para o programador poder analisar
            e.printStackTrace();
            //para mostrar a informação de erro
            Toast.makeText(MainActivity.this,
                    "Could not write BloodCrowd to internal storage.",
                    Toast.LENGTH_LONG).show();
        }

    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.navigation_menu, menu);//vai ao xml e cria os menu item (R.menu.menu_main, menu
        return true;
    }

    public void onClick_NetworkItem(MenuItem item) {



        RequestQueue queue = Volley.newRequestQueue(this);
//fazemos quando a resposta sera um array. No caso será um array de contactos, se fosse um objtivo usariamos uma JsonObjetRequest


        final String url ="http://projetois-1.apphb.com/ServiceBloodCrowd.svc/rest/donors";

        // Creates the json object which will manage the information received

        JsonArrayRequest request = new JsonArrayRequest(
                //null-> no caso não envio nada para o servidor logo é null, do contrario teria de apresentar os dados a enviar
                Request.Method.GET,
                url,
                null,
                new Response.Listener<JSONArray>() {

                    //se correr tudo bem da uma resposta
                    @Override
                    public void onResponse(JSONArray response) {
                          //string json com os contatos existentes na agenda
                        Log.d("Response", response.toString());

                        Gson gson = new GsonBuilder().registerTypeAdapter(Date.class, new JsonDeserializer<Date> () {
                            public Date deserialize(JsonElement json, Type typeOfT, JsonDeserializationContext context) throws JsonParseException {

                                // example string: "/Date(1513943979489+0000)/"
                                String s = json.getAsJsonPrimitive().getAsString();

                                // A plus sign (+) indicates hours ahead of GMT and a minus sign (-) indicates hours behind GMT
                                // https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings
                                // FIX: ignore the sign, and digits after it
                                int gmtIndicatorIndex = s.indexOf('+') == -1 ? s.indexOf('-') : s.indexOf('+');
                                long l;
                                if (gmtIndicatorIndex == -1) {
                                    l = Long.parseLong(s.substring(6, s.length() - 2));
                                } else {
                                    l = Long.parseLong(s.substring(6, gmtIndicatorIndex));
                                }

                                Date d = new Date(l);
                                return d;
                            }
                        }).create();

                          //recebe a string json e a classe para onde sera descerializavda
                        Donor[] donors = gson.fromJson(
                                response.toString(), Donor[].class);



                          //ja tenho a lista de contactos e vou percorre-la
                        for (Donor var_donor : donors ) {

                            Singleton.getInstance().getBloodCrowd().addDonor(var_donor);                                                    }
                          //para refrescar a agenda
                        adapter.notifyDataSetChanged();
                    }
                },
                new Response.ErrorListener() {
                    //se correr mal dá um erro
                    @Override
                    public void onErrorResponse(VolleyError error) {
                        Log.e("Response", error.getMessage());
                        Toast.makeText(MainActivity.this,
                                "Error retrieving contacts from webservice.",
                                Toast.LENGTH_SHORT).show();
                    }
                }
        )
        {
            //vai passar o meu código de xml para json, adicionamos o header a dizer ao webservice que queremos a informação em formato json
            @Override
            public Map<String, String> getHeaders() {
                HashMap<String, String> headers = new HashMap<>();
                headers.put("Content-Type", "application/json");

                return headers;
            }
        };
        queue.add(request);

    }

}
