﻿using System;
using System.Collections.Generic;

namespace TeslaLogger
{

    public class MQTTAutoDiscovery
    {
        public static Dictionary<string, Dictionary<string, string>> autoDiscovery = new Dictionary<string, Dictionary<string, string>>()
        {
//            { autoDiscovery.Add("speed", Dictionary<string, string>) }
        };

        public static string getEntityParamValue(string ent, string param)
        {
            autoDiscovery.TryGetValue(ent, out var value);
            value.TryGetValue(param, out var val);
            return val;
        }

        static MQTTAutoDiscovery()
        {
            // Please refere to Home Assistant documentation:
            // https://www.home-assistant.io/integrations/mqtt/#configuration-via-mqtt-discovery
            // https://www.home-assistant.io/integrations/sensor/#device-class


            autoDiscovery["battery_level"] = new Dictionary<string, string>();
            autoDiscovery["battery_level"]["type"] = "sensor";
            autoDiscovery["battery_level"]["name"] = "Battery Level";
            autoDiscovery["battery_level"]["unit"] = "%";
            autoDiscovery["battery_level"]["class"] = "battery";

            autoDiscovery["power"] = new Dictionary<string, string>();
            autoDiscovery["power"]["type"] = "sensor";
            autoDiscovery["power"]["name"] = "Power";
            autoDiscovery["power"]["unit"] = "kW";
            autoDiscovery["power"]["class"] = "power";

            autoDiscovery["charger_power"] = new Dictionary<string, string>();
            autoDiscovery["charger_power"]["type"] = "sensor";
            autoDiscovery["charger_power"]["name"] = "Charge power";
            autoDiscovery["charger_power"]["unit"] = "kW";
            autoDiscovery["charger_power"]["class"] = "power";

            autoDiscovery["charger_voltage"] = new Dictionary<string, string>();
            autoDiscovery["charger_voltage"]["type"] = "sensor";
            autoDiscovery["charger_voltage"]["name"] = "Charge voltage";
            autoDiscovery["charger_voltage"]["unit"] = "V";
            autoDiscovery["charger_voltage"]["class"] = "voltage";

            autoDiscovery["charger_actual_current"] = new Dictionary<string, string>();
            autoDiscovery["charger_actual_current"]["type"] = "sensor";
            autoDiscovery["charger_actual_current"]["name"] = "Charge current";
            autoDiscovery["charger_actual_current"]["unit"] = "A";
            autoDiscovery["charger_actual_current"]["class"] = "current";

            autoDiscovery["charge_energy_added"] = new Dictionary<string, string>();
            autoDiscovery["charge_energy_added"]["type"] = "sensor";
            autoDiscovery["charge_energy_added"]["name"] = "Energy added";
            autoDiscovery["charge_energy_added"]["unit"] = "kWh";
            autoDiscovery["charge_energy_added"]["class"] = "energy";

            autoDiscovery["charger_phases"] = new Dictionary<string, string>();
            autoDiscovery["charger_phases"]["type"] = "sensor";
            autoDiscovery["charger_phases"]["name"] = "Charge phases";

            autoDiscovery["charge_rate_km"] = new Dictionary<string, string>();
            autoDiscovery["charge_rate_km"]["type"] = "sensor";
            autoDiscovery["charge_rate_km"]["name"] = "Charge rate";
            autoDiscovery["charge_rate_km"]["unit"] = "km/h";
            autoDiscovery["charge_rate_km"]["class"] = "speed";

            autoDiscovery["time_to_full_charge"] = new Dictionary<string, string>();
            autoDiscovery["time_to_full_charge"]["type"] = "sensor";
            autoDiscovery["time_to_full_charge"]["name"] = "Time to full charge";
            autoDiscovery["time_to_full_charge"]["class"] = "duration";

            autoDiscovery["car_version"] = new Dictionary<string, string>();
            autoDiscovery["car_version"]["type"] = "sensor";
            autoDiscovery["car_version"]["name"] = "Firmware version";

            autoDiscovery["software_update_version"] = new Dictionary<string, string>();
            autoDiscovery["software_update_version"]["type"] = "sensor";
            autoDiscovery["software_update_version"]["name"] = "Firmware update version";

            autoDiscovery["software_update_status"] = new Dictionary<string, string>();
            autoDiscovery["software_update_status"]["type"] = "sensor";
            autoDiscovery["software_update_status"]["name"] = "Firmware update status";

            autoDiscovery["display_name"] = new Dictionary<string, string>();
            autoDiscovery["display_name"]["type"] = "sensor";
            autoDiscovery["display_name"]["name"] = "Car name";

            autoDiscovery["latitude"] = new Dictionary<string, string>();
            autoDiscovery["latitude"]["type"] = "sensor";
            autoDiscovery["latitude"]["name"] = "Latitude";

            autoDiscovery["longitude"] = new Dictionary<string, string>();
            autoDiscovery["longitude"]["type"] = "sensor";
            autoDiscovery["longitude"]["name"] = "Longitude";

            autoDiscovery["heading"] = new Dictionary<string, string>();
            autoDiscovery["heading"]["type"] = "sensor";
            autoDiscovery["heading"]["name"] = "Heading";
            autoDiscovery["heading"]["unit"] = "°";

            autoDiscovery["country_code"] = new Dictionary<string, string>();
            autoDiscovery["country_code"]["type"] = "sensor";
            autoDiscovery["country_code"]["name"] = "Country code";

            autoDiscovery["state"] = new Dictionary<string, string>();
            autoDiscovery["state"]["type"] = "sensor";
            autoDiscovery["state"]["name"] = "State";

            autoDiscovery["TLGeofence"] = new Dictionary<string, string>();
            autoDiscovery["TLGeofence"]["type"] = "sensor";
            autoDiscovery["TLGeofence"]["name"] = "Location";

            autoDiscovery["odometer"] = new Dictionary<string, string>();
            autoDiscovery["odometer"]["type"] = "sensor";
            autoDiscovery["odometer"]["name"] = "Odometer";
            autoDiscovery["odometer"]["unit"] = "km";
            autoDiscovery["odometer"]["class"] = "distance";

            autoDiscovery["battery_range_km"] = new Dictionary<string, string>();
            autoDiscovery["battery_range_km"]["type"] = "sensor";
            autoDiscovery["battery_range_km"]["name"] = "Battery range";
            autoDiscovery["battery_range_km"]["unit"] = "km";
            autoDiscovery["battery_range_km"]["class"] = "distance";

            autoDiscovery["ideal_battery_range_km"] = new Dictionary<string, string>();
            autoDiscovery["ideal_battery_range_km"]["type"] = "sensor";
            autoDiscovery["ideal_battery_range_km"]["name"] = "Ideal battery range";
            autoDiscovery["ideal_battery_range_km"]["unit"] = "km";
            autoDiscovery["ideal_battery_range_km"]["class"] = "distance";

            autoDiscovery["inside_temperature"] = new Dictionary<string, string>();
            autoDiscovery["inside_temperature"]["type"] = "sensor";
            autoDiscovery["inside_temperature"]["name"] = "Inside temperature";
            autoDiscovery["inside_temperature"]["unit"] = "°C";
            autoDiscovery["inside_temperature"]["class"] = "temperature";

            autoDiscovery["outside_temp"] = new Dictionary<string, string>();
            autoDiscovery["outside_temp"]["type"] = "sensor";
            autoDiscovery["outside_temp"]["name"] = "Outside temperature";
            autoDiscovery["outside_temp"]["unit"] = "°C";
            autoDiscovery["outside_temp"]["class"] = "temperature";

            autoDiscovery["ts"] = new Dictionary<string, string>();
            autoDiscovery["ts"]["type"] = "sensor";
            autoDiscovery["ts"]["name"] = "Time stamp";
            autoDiscovery["ts"]["class"] = "timestamp";

            autoDiscovery["speed"] = new Dictionary<string, string>();
            autoDiscovery["speed"]["type"] = "sensor";
            autoDiscovery["speed"]["name"] = "Speed";
            autoDiscovery["speed"]["unit"] = "km/h";
            autoDiscovery["speed"]["class"] = "speed";

            autoDiscovery["sleeping"] = new Dictionary<string, string>();
            autoDiscovery["sleeping"]["type"] = "sensor";
            autoDiscovery["sleeping"]["name"] = "Sleeping";

            //autoDiscovery["online"] = new Dictionary<string, string>();
            //autoDiscovery["online"]["type"] = "sensor";
            //["online"]["name"] = "Online";

            autoDiscovery["driving"] = new Dictionary<string, string>();
            autoDiscovery["driving"]["type"] = "sensor";
            autoDiscovery["driving"]["name"] = "Driving";

            autoDiscovery["falling_asleep"] = new Dictionary<string, string>();
            autoDiscovery["falling_asleep"]["type"] = "sensor";
            autoDiscovery["falling_asleep"]["name"] = "Falling Asleep";

            autoDiscovery["plugged_in"] = new Dictionary<string, string>();
            autoDiscovery["plugged_in"]["type"] = "sensor";
            autoDiscovery["plugged_in"]["name"] = "Plugged in";
            autoDiscovery["plugged_in"]["icon"] = "mdi:connection";

            autoDiscovery["battery_heater"] = new Dictionary<string, string>();
            autoDiscovery["battery_heater"]["type"] = "sensor";
            autoDiscovery["battery_heater"]["name"] = "Battery heater";

            autoDiscovery["locked"] = new Dictionary<string, string>();
            autoDiscovery["locked"]["type"] = "sensor";
            autoDiscovery["locked"]["name"] = "Locked";

            autoDiscovery["open_windows"] = new Dictionary<string, string>();
            autoDiscovery["open_windows"]["type"] = "sensor";
            autoDiscovery["open_windows"]["name"] = "Windows opened";

            autoDiscovery["open_doors"] = new Dictionary<string, string>();
            autoDiscovery["open_doors"]["type"] = "sensor";
            autoDiscovery["open_doors"]["name"] = "Doors opened";

            autoDiscovery["frunk"] = new Dictionary<string, string>();
            autoDiscovery["frunk"]["type"] = "sensor";
            autoDiscovery["frunk"]["name"] = "Frunk opened";

            autoDiscovery["trunk"] = new Dictionary<string, string>();
            autoDiscovery["trunk"]["type"] = "sensor";
            autoDiscovery["trunk"]["name"] = "Trunk opened";

            autoDiscovery["TLGeofenceIsHome"] = new Dictionary<string, string>();
            autoDiscovery["TLGeofenceIsHome"]["type"] = "sensor";
            autoDiscovery["TLGeofenceIsHome"]["name"] = "Is Home";

            autoDiscovery["TLGeofenceIsWork"] = new Dictionary<string, string>();
            autoDiscovery["TLGeofenceIsWork"]["type"] = "sensor";
            autoDiscovery["TLGeofenceIsWork"]["name"] = "Is Work";

            autoDiscovery["TLGeofenceIsCharger"] = new Dictionary<string, string>();
            autoDiscovery["TLGeofenceIsCharger"]["type"] = "sensor";
            autoDiscovery["TLGeofenceIsCharger"]["name"] = "Is Charger";

            autoDiscovery["charge_port_door_open"] = new Dictionary<string, string>();
            autoDiscovery["charge_port_door_open"]["type"] = "binary_sensor";
            autoDiscovery["charge_port_door_open"]["name"] = "Charge port opened";
            autoDiscovery["charge_port_door_open"]["pl_on"] = "true";
            autoDiscovery["charge_port_door_open"]["pl_off"] = "false";
            autoDiscovery["charge_port_door_open"]["icon"] = "mdi:ev-plug-ccs2";
            autoDiscovery["charge_port_door_open"]["class"] = "opening";

            autoDiscovery["fast_charger_present"] = new Dictionary<string, string>();
            autoDiscovery["fast_charger_present"]["type"] = "sensor";
            autoDiscovery["fast_charger_present"]["name"] = "Fast charger";

            autoDiscovery["fast_charger_brand"] = new Dictionary<string, string>();
            autoDiscovery["fast_charger_brand"]["type"] = "sensor";
            autoDiscovery["fast_charger_brand"]["name"] = "Fastcharger brand";

            autoDiscovery["sentry_mode"] = new Dictionary<string, string>();
            autoDiscovery["sentry_mode"]["type"] = "switch";
            autoDiscovery["sentry_mode"]["name"] = "Sentry mode";
            autoDiscovery["sentry_mode"]["pl_on"] = "true";
            autoDiscovery["sentry_mode"]["pl_off"] = "false";
            autoDiscovery["sentry_mode"]["cmd_topic"] = "sentry_mode_on_off";
            autoDiscovery["sentry_mode"]["icon"] = "mdi:cctv";

            autoDiscovery["is_preconditioning"] = new Dictionary<string, string>();
            autoDiscovery["is_preconditioning"]["type"] = "switch";
            autoDiscovery["is_preconditioning"]["name"] = "Preconditioning";
            autoDiscovery["is_preconditioning"]["pl_on"] = "true";
            autoDiscovery["is_preconditioning"]["pl_off"] = "false";
            autoDiscovery["is_preconditioning"]["cmd_topic"] = "auto_conditioning_start_stop";
            autoDiscovery["is_preconditioning"]["icon"] = "mdi:heat-wave";

            autoDiscovery["charging"] = new Dictionary<string, string>();
            autoDiscovery["charging"]["type"] = "switch";
            autoDiscovery["charging"]["name"] = "Charging";
            autoDiscovery["charging"]["pl_on"] = "true";
            autoDiscovery["charging"]["pl_off"] = "false";
            autoDiscovery["charging"]["cmd_topic"] = "charge_start_stop";

            autoDiscovery["online"] = new Dictionary<string, string>();
            autoDiscovery["online"]["type"] = "switch";
            autoDiscovery["online"]["name"] = "Online";
            autoDiscovery["online"]["pl_on"] = "true";
            autoDiscovery["online"]["pl_off"] = "false";
            autoDiscovery["online"]["cmd_topic"] = "wake_up";
            autoDiscovery["online"]["icon"] = "mdi:car-connected";

            autoDiscovery["charge_limit_soc"] = new Dictionary<string, string>();
            autoDiscovery["charge_limit_soc"]["type"] = "number";
            autoDiscovery["charge_limit_soc"]["name"] = "Charge limit SoC";
            autoDiscovery["charge_limit_soc"]["cmd_topic"] = "set_charge_limit";
            autoDiscovery["charge_limit_soc"]["class"] = "battery";
            autoDiscovery["charge_limit_soc"]["min"] = "50";
            autoDiscovery["charge_limit_soc"]["max"] = "100";
            autoDiscovery["charge_limit_soc"]["step"] = "1";
            
            autoDiscovery["charge_current_request"] = new Dictionary<string, string>();
            autoDiscovery["charge_current_request"]["type"] = "number";
            autoDiscovery["charge_current_request"]["name"] = "Charge current";
            autoDiscovery["charge_current_request"]["cmd_topic"] = "set_charging_amps";
            autoDiscovery["charge_current_request"]["class"] = "current";
            autoDiscovery["charge_current_request"]["min"] = "1";
            autoDiscovery["charge_current_request"]["max"] = "32";
            autoDiscovery["charge_current_request"]["step"] = "1";

            autoDiscovery["trip_start"] = new Dictionary<string, string>();
            autoDiscovery["trip_start"]["type"] = "sensor";
            autoDiscovery["trip_start"]["name"] = "Trip start";

            autoDiscovery["trip_duration_sec"] = new Dictionary<string, string>();
            autoDiscovery["trip_duration_sec"]["type"] = "sensor";
            autoDiscovery["trip_duration_sec"]["name"] = "Trip Duration";
            autoDiscovery["trip_duration_sec"]["unit"] = "s";
            autoDiscovery["trip_duration_sec"]["class"] = "duration";

            autoDiscovery["trip_start_dt"] = new Dictionary<string, string>();
            autoDiscovery["trip_start_dt"]["type"] = "sensor";
            autoDiscovery["trip_start_dt"]["name"] = "Trip timestamp";
            autoDiscovery["trip_start_dt"]["class"] = "timestamp";

            autoDiscovery["trip_max_speed"] = new Dictionary<string, string>();
            autoDiscovery["trip_max_speed"]["type"] = "sensor";
            autoDiscovery["trip_max_speed"]["name"] = "Trip max. speed";
            autoDiscovery["trip_max_speed"]["unit"] = "km/h";
            autoDiscovery["trip_max_speed"]["class"] = "speed";

            autoDiscovery["trip_max_power"] = new Dictionary<string, string>();
            autoDiscovery["trip_max_power"]["type"] = "sensor";
            autoDiscovery["trip_max_power"]["name"] = "Trip max. power";
            autoDiscovery["trip_max_power"]["unit"] = "kW";
            autoDiscovery["trip_max_power"]["class"] = "power";

            autoDiscovery["trip_kwh"] = new Dictionary<string, string>();
            autoDiscovery["trip_kwh"]["type"] = "sensor";
            autoDiscovery["trip_kwh"]["name"] = "Trip energy consumed";
            autoDiscovery["trip_kwh"]["unit"] = "kWh";
            autoDiscovery["trip_kwh"]["class"] = "energy";

            autoDiscovery["trip_avg_kwh"] = new Dictionary<string, string>();
            autoDiscovery["trip_avg_kwh"]["type"] = "sensor";
            autoDiscovery["trip_avg_kwh"]["name"] = "Trip energy cunsuption";
            autoDiscovery["trip_avg_kwh"]["unit"] = "Wh/km";
            autoDiscovery["trip_avg_kwh"]["class"] = "energy";

            autoDiscovery["trip_distance"] = new Dictionary<string, string>();
            autoDiscovery["trip_distance"]["type"] = "sensor";
            autoDiscovery["trip_distance"]["name"] = "Trip distance";
            autoDiscovery["trip_distance"]["unit"] = "km";
            autoDiscovery["trip_distance"]["class"] = "distance";

            autoDiscovery["active_route_destination"] = new Dictionary<string, string>();
            autoDiscovery["active_route_destination"]["type"] = "sensor";
            autoDiscovery["active_route_destination"]["name"] = "Route destination";

            autoDiscovery["active_route_energy_at_arrival"] = new Dictionary<string, string>();
            autoDiscovery["active_route_energy_at_arrival"]["type"] = "sensor";
            autoDiscovery["active_route_energy_at_arrival"]["name"] = "Route energy at arrival";
            autoDiscovery["active_route_energy_at_arrival"]["unit"] = "%";
            autoDiscovery["active_route_energy_at_arrival"]["class"] = "battery";

            autoDiscovery["active_route_minutes_to_arrival"] = new Dictionary<string, string>();
            autoDiscovery["active_route_minutes_to_arrival"]["type"] = "sensor";
            autoDiscovery["active_route_minutes_to_arrival"]["name"] = "Route minutes until destination";
            autoDiscovery["active_route_minutes_to_arrival"]["unit"] = "min";
            autoDiscovery["active_route_minutes_to_arrival"]["class"] = "duration";

            autoDiscovery["active_route_traffic_minutes_delay"] = new Dictionary<string, string>();
            autoDiscovery["active_route_traffic_minutes_delay"]["type"] = "sensor";
            autoDiscovery["active_route_traffic_minutes_delay"]["name"] = "Route traffic delay";
            autoDiscovery["active_route_traffic_minutes_delay"]["unit"] = "min";
            autoDiscovery["active_route_traffic_minutes_delay"]["class"] = "duration";

            autoDiscovery["active_route_latitude"] = new Dictionary<string, string>();
            autoDiscovery["active_route_latitude"]["type"] = "sensor";
            autoDiscovery["active_route_latitude"]["name"] = "Route destination latitude";

            autoDiscovery["active_route_longitude"] = new Dictionary<string, string>();
            autoDiscovery["active_route_longitude"]["type"] = "sensor";
            autoDiscovery["active_route_longitude"]["name"] = "Route destination longitude";
        }

    }
}

