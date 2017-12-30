package pt.ipleiria.celsoteixeira.mobileapplication;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.Spinner;
import android.widget.Toast;

import java.util.ArrayList;

import pt.ipleiria.celsoteixeira.mobileapplication.model.Donor;
import pt.ipleiria.celsoteixeira.mobileapplication.model.Singleton;

public class Activity_search_ByBloodType extends AppCompatActivity {
    private ListView listView_search;
Spinner blood_spinner;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_search__by_blood_type);
        this.listView_search = findViewById(R.id.listView_searchByBlood);
    }

    public void button_searchByBlood(View view) {

         blood_spinner = (Spinner)findViewById(R.id.bloodtype_spinner);

         String blood= blood_spinner.getSelectedItem().toString();
        ArrayList<Donor> searchedDonors = Singleton.getInstance().getBloodCrowd().searchDonorsByBlood(blood);

        ArrayAdapter<Donor> adapter = new ArrayAdapter<Donor>(this, android.R.layout.simple_list_item_1, searchedDonors);
        listView_search.setAdapter(adapter);

        //mostar uma toast caso não tenhaam sido encontrados contactos
        if (searchedDonors.isEmpty()) {
            Toast.makeText(this, "No Contacts found...",Toast.LENGTH_LONG).show();
        }
    }
}
