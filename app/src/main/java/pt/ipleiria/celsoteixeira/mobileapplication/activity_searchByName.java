package pt.ipleiria.celsoteixeira.mobileapplication;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.Toast;

import java.util.ArrayList;

import pt.ipleiria.celsoteixeira.mobileapplication.model.BloodCrowd;
import pt.ipleiria.celsoteixeira.mobileapplication.model.Donor;
import pt.ipleiria.celsoteixeira.mobileapplication.model.Singleton;



public class activity_searchByName extends AppCompatActivity implements OnClickListener, BloodCrowd.VolleyTaskComplete {
    private ListView listView_search;
    private Button buttonSearch;



    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_search_by_name);

        this.listView_search = findViewById(R.id.listView_search);
        this.buttonSearch = findViewById(R.id.button_searchByName);
        this.buttonSearch.setOnClickListener(this);
    }

    public void button_searchByName(View view) {
        // quando clicar o botão, ir buscar o termo pesquisar a editText
        EditText editText_search = findViewById(R.id.editText_search);
        String nameToSearch = editText_search.getText().toString();
        //Efetuar a pesquisa na agenda
        Singleton.getInstance().getBloodCrowd()
                .searchDonorsByName(nameToSearch, this);

    }

    @Override
    public void onClick(View view) {
        switch (view.getId()) {
            case R.id.button_searchByName:
                button_searchByName(view);
                break;
        }
    }

    @Override
    public void complete(ArrayList<Donor> array) {
        //Mostrar os resultados na listView
        ArrayAdapter<Donor> adapter = new ArrayAdapter<>(this, android.R.layout
                .simple_list_item_1, array);

        listView_search.setAdapter(adapter);
        //listView_search.notify();
        //mostar uma toast caso não tenhaam sido encontrados contactos
        if (array.size() <= 0) {
            Toast.makeText(this, "No Contacts found...", Toast.LENGTH_LONG).show();
        }
    }
}
