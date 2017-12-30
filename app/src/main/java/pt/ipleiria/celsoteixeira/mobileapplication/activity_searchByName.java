package pt.ipleiria.celsoteixeira.mobileapplication;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.Toast;

import java.util.ArrayList;

import pt.ipleiria.celsoteixeira.mobileapplication.model.Donor;
import pt.ipleiria.celsoteixeira.mobileapplication.model.Singleton;

public class activity_searchByName extends AppCompatActivity {
    private ListView listView_search;
    private button_searc

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_search_by_name);

        this.listView_search = findViewById(R.id.listView_search);



    }
    public void button_searchByName(View view) {
        // quando clicar o botão, ir buscar o termo pesquisar a editText
        EditText editText_search = findViewById(R.id.editText_search);
        String nameToSearch = editText_search.getText().toString();
        //Efetuar a pesquisa na agenda
        ArrayList<Donor> searchedContacts = Singleton.getInstance().getBloodCrowd().searchDonorsByName(nameToSearch);

        //Mostrar os resultados na listView
        ArrayAdapter<Donor> adapter = new ArrayAdapter<Donor>(this, android.R.layout.simple_list_item_1, searchedContacts);
        listView_search.setAdapter(adapter);
        listView_search.notify();
        //mostar uma toast caso não tenhaam sido encontrados contactos
        if (searchedContacts.isEmpty()) {
            Toast.makeText(this, "No Contacts found...",Toast.LENGTH_LONG).show();
        }
    }
}
