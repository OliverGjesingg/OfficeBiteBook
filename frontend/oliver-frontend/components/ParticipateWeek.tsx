"use client"
import { supabase } from "@/components/SupabaseClient";
import { useState, useEffect } from "react";
import { motion } from 'framer-motion';
import { ToastContainer, toast } from "react-toastify";
import "react-toastify/dist/ReactToastify.css";

interface ParticipateWeekProps {
  menus: any[];
  weekNumber: number;
  userId?: string;
  menuUser: any[] | null;
}

export default function ParticipateWeek({ menus, weekNumber, userId, menuUser  }: ParticipateWeekProps) {
  const [toggle, setToggle] = useState<boolean>(false);

  const actualUserId = userId || "";

  useEffect(() => {
    const checkWeekParticipation = async () => {
      try {
        if (supabase) {
          // Check if the user has participated in all menus for the week
          const participatedMenus = menusThisWeek?.filter((menu) =>
            menus.some((weekMenu) => weekMenu.menu_id === menu.menu_id)
          );
          // If the user has participated in all menus, set toggle to true
          setToggle(participatedMenus?.length === menus.length);
        } else {
          console.error("Supabase client is null");
        }
      } catch (error) {
        console.error("Error checking week participation", error);
      }
    };

    // Call the checkWeekParticipation function when the component mounts
    checkWeekParticipation();
  }, [menus, menuUser]);

const notify = (message : string) => toast(message, { autoClose: 2000 });

  const handleToggle = async () => {
    // setToggle(!toggle);

      try {
        // Iterate through all menus in the given week
        for (const menu of menus) {
          // Add your participation logic here (similar to ParticipateDay)
          await handleParticipation(menu.menu_id, actualUserId);
        }
      } catch (error) {
        console.error('Error participating in the week:', error);
      }
  };

  var startDate = new Date();


  const menusThisWeek = menus?.filter((menu) =>
            menus.some(() => new Date(menu.menu_date).getTime() - startDate.getTime() >= -1)
          );
  const menu1 = menusThisWeek[0]
  const menu2 = menusThisWeek[1]
  const menu3 = menusThisWeek[2]
  const menu4 = menusThisWeek[3]
  const menu5 = menusThisWeek[4]
  const menu6 = menusThisWeek[5]
  const menu7 = menusThisWeek[6]

  console.log(menu1?.menu_id)

  const handleParticipation = async (menuId: string, userId: string) => {
    if (supabase) {
      if(menu7?.menu_id != null){
        const { data, error } = await supabase.from("menu_user").insert([
        {menu_id: menu1?.menu_id, user_id: userId}, 
        {menu_id: menu2?.menu_id, user_id: userId}, 
        {menu_id: menu3?.menu_id, user_id: userId}, 
        {menu_id: menu4?.menu_id, user_id: userId}, 
        {menu_id: menu5?.menu_id, user_id: userId}, 
        {menu_id: menu6?.menu_id, user_id: userId}, 
        {menu_id: menu7?.menu_id, user_id: userId} 
      ]);
      location.reload()

      if (error) throw error;
      } else if(menu6?.menu_id != null){
        const { data, error } = await supabase.from("menu_user").insert([
          {menu_id: menu1?.menu_id, user_id: userId}, 
          {menu_id: menu2?.menu_id, user_id: userId}, 
          {menu_id: menu3?.menu_id, user_id: userId}, 
          {menu_id: menu4?.menu_id, user_id: userId}, 
          {menu_id: menu5?.menu_id, user_id: userId}, 
          {menu_id: menu6?.menu_id, user_id: userId}
        ]);
        location.reload()
  
        if (error) throw error;
      } else if(menu5?.menu_id != null){
        const { data, error } = await supabase.from("menu_user").insert([
          {menu_id: menu1?.menu_id, user_id: userId}, 
          {menu_id: menu2?.menu_id, user_id: userId}, 
          {menu_id: menu3?.menu_id, user_id: userId}, 
          {menu_id: menu4?.menu_id, user_id: userId}, 
          {menu_id: menu5?.menu_id, user_id: userId}
        ]);
        location.reload()
  
        if (error) throw error;
      } else if(menu4?.menu_id != null){
        const { data, error } = await supabase.from("menu_user").insert([
          {menu_id: menu1?.menu_id, user_id: userId}, 
          {menu_id: menu2?.menu_id, user_id: userId}, 
          {menu_id: menu3?.menu_id, user_id: userId}, 
          {menu_id: menu4?.menu_id, user_id: userId}
        ]);
        location.reload()
  
        if (error) throw error;
      } else if(menu3?.menu_id != null){
        const { data, error } = await supabase.from("menu_user").insert([
          {menu_id: menu1?.menu_id, user_id: userId}, 
          {menu_id: menu2?.menu_id, user_id: userId}, 
          {menu_id: menu3?.menu_id, user_id: userId}
        ]);
        location.reload()
  
        if (error) throw error;
      } else if(menu2?.menu_id !=null){
        const { data, error } = await supabase.from("menu_user").insert([
          {menu_id: menu1?.menu_id, user_id: userId}, 
          {menu_id: menu2?.menu_id, user_id: userId}
        ]);
        location.reload()
  
        if (error) throw error;
      } else if(menu1?.menu_id !=null){
        const { data, error } = await supabase.from("menu_user").insert([
          {menu_id: menu1?.menu_id, user_id: userId}
        ]);
        location.reload()
        notify("Du deltager den ")

  
        if (error) throw error;
      }
      else(
        console.log("there is no menus this week?")
      )

    } else {
      console.log("Supabase client is null");
    }
  };
  const handleUnparticipation = async (menuId: string, userId: string) => {
    try {
      if (supabase) {
        const { error } = await supabase.from("menu_user").delete().eq('menu_id', menuId).eq('user_id', userId);
        if (error) throw error;
        location.reload()
      } else {
        console.error("Supabase client is null");
      }
    } catch (error) {
      console.error("Error deleting data", error);
    }
  };

  return (
    <div>
      
      <ToastContainer />
    
    <div className="flex flex-row cursor-pointer" onClick={handleToggle}>
    <p className="mr-3">Deltag alle dage</p>
      </div> 
    </div>
  );
}
