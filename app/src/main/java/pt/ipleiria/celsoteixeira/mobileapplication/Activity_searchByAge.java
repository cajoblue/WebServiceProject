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

public class Activity_searchByAge extends AppCompatActivity {
    private ListView listView_search;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_search_by_age);
        this.listView_search = findViewById(R.id.listView_searchByAge);


    }

    public void button_searchByAge(View view){
        EditText editText_minAge = findViewById(R.id.minAge);
        int minAge= Integer.parseInt(editText_minAge.getText().toString());
        EditText editText_maxAge = findViewById(R.id.maxAge);
        int maxAge= Integer.parseInt(editText_maxAge.getText().toString());

        ArrayList<Donor> searchedContacts = Singleton.getInstance().getBloodCrowd().searchDonorsByAge(minAge,maxAge);

        //Mostrar os resultados na listView
        ArrayAdapter<Donor> adapter = new ArrayAdapter<Donor>(this, android.R.layout.simple_list_item_1, searchedContacts);
        listView_search.setAdapter(adapter);

        //mostar uma toast caso não tenhaam sido encontrados contactos
        if (searchedContacts.isEmpty()) {
            Toast.makeText(this, "No Contacts found...",Toast.LENGTH_LONG).show();
        }


    }
}
