import React from 'react'
import { createClient } from "@/utils/supabase/server";
import { cookies } from "next/headers";
import MenuList from './MenuList';

export default async function home() {
    const cookieStore = cookies();
    const supabase = createClient(cookieStore);
    const { data: guests } = await supabase.from("guest").select();
    const { data: menuUser } = await supabase.from("menu_user").select();
    const { data: menus, error } = await supabase.from("menus").select();
  // .eq("published", true)

  if (error) {
    console.error("error fetching data:", error);
    return <div>Error fetching data!</div>
  }

  //this gets the user from authentication
  const {
    data: { user },
  } = await supabase.auth.getUser();

  //get the userid
  const userId = user?.id;


  return (
    <div>
        <MenuList guests={guests} menuUser={menuUser} menus={menus} userId={userId}/>
    </div>
  )
}