package pt.ipleiria.celsoteixeira.mobileapplication.model;

import android.content.BroadcastReceiver;
import android.content.ComponentName;
import android.content.ContentResolver;
import android.content.Context;
import android.content.Intent;
import android.content.IntentFilter;
import android.content.IntentSender;
import android.content.ServiceConnection;
import android.content.SharedPreferences;
import android.content.pm.ApplicationInfo;
import android.content.pm.PackageManager;
import android.content.res.AssetManager;
import android.content.res.Configuration;
import android.content.res.Resources;
import android.database.DatabaseErrorHandler;
import android.database.sqlite.SQLiteDatabase;
import android.graphics.Bitmap;
import android.graphics.drawable.Drawable;
import android.net.Uri;
import android.os.Bundle;
import android.os.Handler;
import android.os.Looper;
import android.os.UserHandle;
import android.support.annotation.NonNull;
import android.support.annotation.Nullable;
import android.support.v7.app.AppCompatActivity;
import android.util.Log;
import android.view.Display;
import android.widget.ArrayAdapter;
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

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.Serializable;
import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.Date;
import java.util.HashMap;
import java.util.Map;

import pt.ipleiria.celsoteixeira.mobileapplication.MainActivity;

/**
 * Created by celsoTeixeira on 12/18/2017.
 */

public class BloodCrowd extends Context implements Serializable {

    private ArrayAdapter<Donor> adapter;
    private ArrayList<Donor> donors;
    private ArrayList<String> bloodTypes = new ArrayList<String>();

    public BloodCrowd() {
        this.donors = new ArrayList<>();
    }

    @Override
    public AssetManager getAssets() {
        return null;
    }

    @Override
    public Resources getResources() {
        return null;
    }

    @Override
    public PackageManager getPackageManager() {
        return null;
    }

    @Override
    public ContentResolver getContentResolver() {
        return null;
    }

    @Override
    public Looper getMainLooper() {
        return null;
    }

    @Override
    public Context getApplicationContext() {
        return null;
    }

    @Override
    public void setTheme(int i) {

    }

    @Override
    public Resources.Theme getTheme() {
        return null;
    }

    @Override
    public ClassLoader getClassLoader() {
        return null;
    }

    @Override
    public String getPackageName() {
        return null;
    }

    @Override
    public ApplicationInfo getApplicationInfo() {
        return null;
    }

    @Override
    public String getPackageResourcePath() {
        return null;
    }

    @Override
    public String getPackageCodePath() {
        return null;
    }

    @Override
    public SharedPreferences getSharedPreferences(String s, int i) {
        return null;
    }

    @Override
    public boolean moveSharedPreferencesFrom(Context context, String s) {
        return false;
    }

    @Override
    public boolean deleteSharedPreferences(String s) {
        return false;
    }

    @Override
    public FileInputStream openFileInput(String s) throws FileNotFoundException {
        return null;
    }

    @Override
    public FileOutputStream openFileOutput(String s, int i) throws FileNotFoundException {
        return null;
    }

    @Override
    public boolean deleteFile(String s) {
        return false;
    }

    @Override
    public File getFileStreamPath(String s) {
        return null;
    }

    @Override
    public File getDataDir() {
        return null;
    }

    @Override
    public File getFilesDir() {
        return null;
    }

    @Override
    public File getNoBackupFilesDir() {
        return null;
    }

    @Nullable
    @Override
    public File getExternalFilesDir(@Nullable String s) {
        return null;
    }

    @Override
    public File[] getExternalFilesDirs(String s) {
        return new File[0];
    }

    @Override
    public File getObbDir() {
        return null;
    }

    @Override
    public File[] getObbDirs() {
        return new File[0];
    }

    @Override
    public File getCacheDir() {
        return null;
    }

    @Override
    public File getCodeCacheDir() {
        return null;
    }

    @Nullable
    @Override
    public File getExternalCacheDir() {
        return null;
    }

    @Override
    public File[] getExternalCacheDirs() {
        return new File[0];
    }

    @Override
    public File[] getExternalMediaDirs() {
        return new File[0];
    }

    @Override
    public String[] fileList() {
        return new String[0];
    }

    @Override
    public File getDir(String s, int i) {
        return null;
    }

    @Override
    public SQLiteDatabase openOrCreateDatabase(String s, int i, SQLiteDatabase.CursorFactory cursorFactory) {
        return null;
    }

    @Override
    public SQLiteDatabase openOrCreateDatabase(String s, int i, SQLiteDatabase.CursorFactory cursorFactory, @Nullable DatabaseErrorHandler databaseErrorHandler) {
        return null;
    }

    @Override
    public boolean moveDatabaseFrom(Context context, String s) {
        return false;
    }

    @Override
    public boolean deleteDatabase(String s) {
        return false;
    }

    @Override
    public File getDatabasePath(String s) {
        return null;
    }

    @Override
    public String[] databaseList() {
        return new String[0];
    }

    @Override
    public Drawable getWallpaper() {
        return null;
    }

    @Override
    public Drawable peekWallpaper() {
        return null;
    }

    @Override
    public int getWallpaperDesiredMinimumWidth() {
        return 0;
    }

    @Override
    public int getWallpaperDesiredMinimumHeight() {
        return 0;
    }

    @Override
    public void setWallpaper(Bitmap bitmap) throws IOException {

    }

    @Override
    public void setWallpaper(InputStream inputStream) throws IOException {

    }

    @Override
    public void clearWallpaper() throws IOException {

    }

    @Override
    public void startActivity(Intent intent) {

    }

    @Override
    public void startActivity(Intent intent, @Nullable Bundle bundle) {

    }

    @Override
    public void startActivities(Intent[] intents) {

    }

    @Override
    public void startActivities(Intent[] intents, Bundle bundle) {

    }

    @Override
    public void startIntentSender(IntentSender intentSender, @Nullable Intent intent, int i, int i1, int i2) throws IntentSender.SendIntentException {

    }

    @Override
    public void startIntentSender(IntentSender intentSender, @Nullable Intent intent, int i, int i1, int i2, @Nullable Bundle bundle) throws IntentSender.SendIntentException {

    }

    @Override
    public void sendBroadcast(Intent intent) {

    }

    @Override
    public void sendBroadcast(Intent intent, @Nullable String s) {

    }

    @Override
    public void sendOrderedBroadcast(Intent intent, @Nullable String s) {

    }

    @Override
    public void sendOrderedBroadcast(@NonNull Intent intent, @Nullable String s, @Nullable BroadcastReceiver broadcastReceiver, @Nullable Handler handler, int i, @Nullable String s1, @Nullable Bundle bundle) {

    }

    @Override
    public void sendBroadcastAsUser(Intent intent, UserHandle userHandle) {

    }

    @Override
    public void sendBroadcastAsUser(Intent intent, UserHandle userHandle, @Nullable String s) {

    }

    @Override
    public void sendOrderedBroadcastAsUser(Intent intent, UserHandle userHandle, @Nullable String s, BroadcastReceiver broadcastReceiver, @Nullable Handler handler, int i, @Nullable String s1, @Nullable Bundle bundle) {

    }

    @Override
    public void sendStickyBroadcast(Intent intent) {

    }

    @Override
    public void sendStickyOrderedBroadcast(Intent intent, BroadcastReceiver broadcastReceiver, @Nullable Handler handler, int i, @Nullable String s, @Nullable Bundle bundle) {

    }

    @Override
    public void removeStickyBroadcast(Intent intent) {

    }

    @Override
    public void sendStickyBroadcastAsUser(Intent intent, UserHandle userHandle) {

    }

    @Override
    public void sendStickyOrderedBroadcastAsUser(Intent intent, UserHandle userHandle, BroadcastReceiver broadcastReceiver, @Nullable Handler handler, int i, @Nullable String s, @Nullable Bundle bundle) {

    }

    @Override
    public void removeStickyBroadcastAsUser(Intent intent, UserHandle userHandle) {

    }

    @Nullable
    @Override
    public Intent registerReceiver(@Nullable BroadcastReceiver broadcastReceiver, IntentFilter intentFilter) {
        return null;
    }

    @Nullable
    @Override
    public Intent registerReceiver(@Nullable BroadcastReceiver broadcastReceiver, IntentFilter intentFilter, int i) {
        return null;
    }

    @Nullable
    @Override
    public Intent registerReceiver(BroadcastReceiver broadcastReceiver, IntentFilter intentFilter, @Nullable String s, @Nullable Handler handler) {
        return null;
    }

    @Nullable
    @Override
    public Intent registerReceiver(BroadcastReceiver broadcastReceiver, IntentFilter intentFilter, @Nullable String s, @Nullable Handler handler, int i) {
        return null;
    }

    @Override
    public void unregisterReceiver(BroadcastReceiver broadcastReceiver) {

    }

    @Nullable
    @Override
    public ComponentName startService(Intent intent) {
        return null;
    }

    @Nullable
    @Override
    public ComponentName startForegroundService(Intent intent) {
        return null;
    }

    @Override
    public boolean stopService(Intent intent) {
        return false;
    }

    @Override
    public boolean bindService(Intent intent, @NonNull ServiceConnection serviceConnection, int i) {
        return false;
    }

    @Override
    public void unbindService(@NonNull ServiceConnection serviceConnection) {

    }

    @Override
    public boolean startInstrumentation(@NonNull ComponentName componentName, @Nullable String s, @Nullable Bundle bundle) {
        return false;
    }

    @Nullable
    @Override
    public Object getSystemService(@NonNull String s) {
        return null;
    }

    @Nullable
    @Override
    public String getSystemServiceName(@NonNull Class<?> aClass) {
        return null;
    }

    @Override
    public int checkPermission(@NonNull String s, int i, int i1) {
        return 0;
    }

    @Override
    public int checkCallingPermission(@NonNull String s) {
        return 0;
    }

    @Override
    public int checkCallingOrSelfPermission(@NonNull String s) {
        return 0;
    }

    @Override
    public int checkSelfPermission(@NonNull String s) {
        return 0;
    }

    @Override
    public void enforcePermission(@NonNull String s, int i, int i1, @Nullable String s1) {

    }

    @Override
    public void enforceCallingPermission(@NonNull String s, @Nullable String s1) {

    }

    @Override
    public void enforceCallingOrSelfPermission(@NonNull String s, @Nullable String s1) {

    }

    @Override
    public void grantUriPermission(String s, Uri uri, int i) {

    }

    @Override
    public void revokeUriPermission(Uri uri, int i) {

    }

    @Override
    public void revokeUriPermission(String s, Uri uri, int i) {

    }

    @Override
    public int checkUriPermission(Uri uri, int i, int i1, int i2) {
        return 0;
    }

    @Override
    public int checkCallingUriPermission(Uri uri, int i) {
        return 0;
    }

    @Override
    public int checkCallingOrSelfUriPermission(Uri uri, int i) {
        return 0;
    }

    @Override
    public int checkUriPermission(@Nullable Uri uri, @Nullable String s, @Nullable String s1, int i, int i1, int i2) {
        return 0;
    }

    @Override
    public void enforceUriPermission(Uri uri, int i, int i1, int i2, String s) {

    }

    @Override
    public void enforceCallingUriPermission(Uri uri, int i, String s) {

    }

    @Override
    public void enforceCallingOrSelfUriPermission(Uri uri, int i, String s) {

    }

    @Override
    public void enforceUriPermission(@Nullable Uri uri, @Nullable String s, @Nullable String s1, int i, int i1, int i2, @Nullable String s2) {

    }

    @Override
    public Context createPackageContext(String s, int i) throws PackageManager.NameNotFoundException {
        return null;
    }

    @Override
    public Context createContextForSplit(String s) throws PackageManager.NameNotFoundException {
        return null;
    }

    @Override
    public Context createConfigurationContext(@NonNull Configuration configuration) {
        return null;
    }

    @Override
    public Context createDisplayContext(@NonNull Display display) {
        return null;
    }

    @Override
    public Context createDeviceProtectedStorageContext() {
        return null;
    }

    @Override
    public boolean isDeviceProtectedStorage() {
        return false;
    }

    public ArrayList<Donor> getDonors() {
        return donors;
    }

    public ArrayList<String> getBloodTypes() {

        return bloodTypes;
    }


    @Override
    public String toString() {
        String res = "";
        for (Donor var_dono : donors) {
            res += var_dono + "\n";
        }
        return res;
    }

    public void addDonor(Donor donor) {

        if (containsGUID(donor.getGuid())) {
            throw new RuntimeException("Cannot add Donor to BloodCrowd; guid already exists.");

        }
        donors.add(donor);

    }

    public void addBloodType(String bloodtype) {


        bloodTypes.add(bloodtype);

    }

    public boolean containsGUID(String guid) {
        for (Donor c : donors) {
            //verifica se o numero de contato inserido é igual a um numero existente na lista de  contactos
            boolean valida = c.getGuid().contentEquals(guid);
            if (valida) {
                return true;
            }
        }
        return false;
    }

    public ArrayList<Donor> searchDonorsByName(String name) {


        final String url = "http://projetois-1.apphb.com/ServiceBloodCrowd.svc/rest/searchByName?donorName=" + name;
        ArrayList<Donor> res = webserviceRequest(url);


        return res;
    }

    public ArrayList<Donor> searchDonorsByAge(int minAge, int maxAge) {

        final String url = "http://projetois-1.apphb.com/ServiceBloodCrowd.svc/rest/searchByAge?minAge=" + minAge + "&maxAge=" + maxAge;
        ArrayList<Donor> res = webserviceRequest(url);

        /*
        ArrayList<Donor> res = new ArrayList<>();
        for (Donor c : donors) {
            if (c.getAge()>=minAge && c.getAge()<=maxAge ) {
                res.add(c);
            }
        }
        */
        return webserviceRequest(url);
    }

    public ArrayList<Donor> searchDonorsByIMc(double minImc, double maxImc) {
        ArrayList<Donor> res = new ArrayList<>();
        for (Donor c : donors) {
            if (c.getImc() >= minImc && c.getImc() <= maxImc) {
                res.add(c);
            }
        }
        return res;
    }

    public ArrayList<Donor> searchDonorsByBlood(String blood) {
        String teste = blood;

        ArrayList<Donor> res = new ArrayList<>();
        for (Donor c : donors) {

            if (c.getBloodType().equalsIgnoreCase(teste.trim())) {
                res.add(c);
            }
        }
        return res;
    }


    public ArrayList<Donor> webserviceRequest(String url) {
        RequestQueue queue = Volley.newRequestQueue(this);
        final ArrayList<Donor> list_donors = new ArrayList<Donor>();
        //fazemos quando a resposta sera um array. No caso será um array de contactos, se fosse um objtivo usariamos uma JsonObjetRequest


        // final String url ="http://projetois-1.apphb.com/ServiceBloodCrowd.svc/rest/donors";


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
                        //*string json com os contatos existentes na agenda
                        Log.d("Response", response.toString());

                        Gson gson = new GsonBuilder().registerTypeAdapter(Date.class, new JsonDeserializer<Date>() {
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

                        //*recebe a string json e a classe para onde sera descerializavda
                        Donor[] donors = gson.fromJson(
                                response.toString(), Donor[].class);


                        //*ja tenho a lista de contactos e vou percorre-la
                        for (Donor var_donor : donors) {

                            list_donors.add(var_donor);
                        }
                        //*para refrescar a agenda
                        //  adapter.notifyDataSetChanged();
                    }
                },
                new Response.ErrorListener() {
                    //se correr mal dá um erro
                    @Override
                    public void onErrorResponse(VolleyError error) {
                        Log.e("Response", error.getMessage());
                        //Toast.makeText(.this, "Error retrieving contacts from webservice.", Toast.LENGTH_SHORT).show();
                    }
                }
        ) {
            //*vai passar o meu código de xml para json, adicionamos o header a dizer ao webservice que queremos a informação em formato json
            @Override
            public Map<String, String> getHeaders() {
                HashMap<String, String> headers = new HashMap<>();
                headers.put("Content-Type", "application/json");

                return headers;
            }
        };
        queue.add(request);

        return list_donors;
    }

}
